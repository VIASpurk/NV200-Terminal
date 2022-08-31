using NetworkLibrary;
using NetworkLibrary.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Operator
{
    public partial class PaymentControl : UserControl
    {
        public PaymentControl()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }

        public int NamePC { get; set; }
        public ServerHost server { get; set; }

        private Stopwatch stopwach = new Stopwatch();

        private readonly int time = 60;

        private void PaymentControl_Load(object sender, EventArgs e)
        {
            labelPC.Text = $"ПК {NamePC}";
            // labelSum.Text = "";
            pictureBoxPay.Visible = false;
            labelTime.Text = "";
            stopwach.Start();
            timerPay.Enabled = true;
            NamePC = NamePC;
            textBoxPayment.Text = "100";
        }

        private void SetCompleted()
        {
            PayoutButton.Visible = false;
            pictureBoxPay.Visible = true;

            textBoxPayment.ReadOnly = true;
            textBoxPayment.BorderStyle = BorderStyle.None;
            textBoxPayment.ForeColor = Color.Black;

            labelPC.BackColor = Color.GreenYellow;
            textBoxPayment.BackColor = Color.GreenYellow;
            pictureBoxPay.BackColor = Color.GreenYellow;
            labelTime.BackColor = Color.GreenYellow;
        }

        private void SetFailed()
        {
            PayoutButton.Visible = false;
            pictureBoxPay.Visible = true;

            textBoxPayment.ReadOnly = true;

            var failColor = Color.LightGray;
            labelPC.BackColor = failColor;
            textBoxPayment.BackColor = failColor;
            labelTime.BackColor = failColor;
            pictureBoxPay.BackColor = failColor;

            pictureBoxPay.Image = Properties.Resources.icons8_close_144;
        }

        private void PayoutButton_Click(object sender, EventArgs e)
        {
            if (textBoxPayment.Cash == 0)
            {
                return;
            }


            if (PayoutButton.Enabled)
            {
                PayoutButton.Enabled = false;

            }
            else
            {
                return;
            }    
            server.Pay(NamePC, textBoxPayment.Cash);
            server.PayoutResult += Server_PayoutResult;
        }

        private void Server_PayoutResult(PayoutResult obj)
        {
            server.PayoutResult -= Server_PayoutResult;
            timerPay.Enabled = false;
            stopwach.Stop();
            this.Invoke(new Action(() =>
            {
            if (string.IsNullOrEmpty(obj.ErrorMessage))
            {
                labelTime.Text = DateTime.Now.ToString("dd.MM HH:mm");
                    SetCompleted();
                

            }
            else
            {
                labelTime.Text = DateTime.Now.ToString("dd.MM HH:mm");
                    SetFailed();

                    ErrorToolTip.SetToolTip(pictureBoxPay, $"ошибка терминала. Компьютер {obj.PCName} {obj.ErrorMessage}");
                
                }
            }));
        }

        private void timerPay_Tick(object sender, EventArgs e)
        {
            var seconds = stopwach.Elapsed.Seconds;
            labelTime.Text = seconds.ToString();
            //time = time - 1;
           
            if (stopwach.Elapsed.TotalSeconds >= time)
            {
                stopwach.Stop();
                timerPay.Enabled = false;
                PayoutButton.Enabled = false;
                server.PayoutResult -= Server_PayoutResult;
                labelTime.Text = DateTime.Now.ToString("dd.MM HH:mm");
                textBoxPayment.Text = "отменен";
                SetFailed();
            }
        }

      

	}
}
