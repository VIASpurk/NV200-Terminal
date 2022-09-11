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
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Operator
{
    public partial class PaymentControl : BaseInfoControl
    {
        public PaymentControl()
        {
            InitializeComponent();
            BackColor = Color.White;

            CurrentInfo.State = 1;
            CurrentInfo.TypeID = 2;
            CurrentInfo.Position = 0;
            CurrentInfo.IncomeDate = DateTime.Now;
        }

        private readonly Stopwatch stopwach = new Stopwatch();
        private readonly int time = 60;

        private CashInfo[] availableCash;

        private void PaymentControl_Load(object sender, EventArgs e)
        {
            labelPC.Text = $"ПК {CurrentInfo.PCName}";
            pictureBoxPay.Visible = false;
            labelTime.Text = "";

            switch (CurrentInfo.State)
			{
                case 2:
                    SetCompleted();
                    break;
                case 3:
                    textBoxPayment.Text = "отменен";
                    SetFailed();
                    break;
                default:
                    stopwach.Start();
                    timerPay.Enabled = true;
                    break;
			}
        }

        private void SetCompleted()
        {
            CurrentInfo.State = 2;

            PayoutButton.Visible = false;
            pictureBoxPay.Visible = true;

            textBoxPayment.ReadOnly = true;
            textBoxPayment.BorderStyle = BorderStyle.None;
            textBoxPayment.ForeColor = Color.Black;

            labelPC.BackColor = ColorConstants.GreenColor;
            textBoxPayment.BackColor = ColorConstants.GreenColor;
            pictureBoxPay.BackColor = ColorConstants.GreenColor;
            labelTime.BackColor = ColorConstants.GreenColor;
        }

        private void SetFailed()
        {
            CurrentInfo.State = 3;

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
            int amount = textBoxPayment.Cash;

            if (amount == 0)
            {
                return;
            }

            if (Server == null)
			{
                SetFailed();
                return;
			}

            //Добавить проверку. Можем выдать введенную сумму?
            if (!CanPayoutAmout(amount, out string error))
			{
                MessageBox.Show(error);
                return;
			}

            if (PayoutButton.Enabled)
            {
                PayoutButton.Enabled = false;
                textBoxPayment.ReadOnly = true;
            }
            else
            {
                return;
            }


            Server.Pay(CurrentInfo.PCName, amount);
            Server.PayoutResult += Server_PayoutResult;
        }

		private bool CanPayoutAmout(int amount, out string error)
		{
            // TODO: Проверка наличия банкнот на указанную сумму
            var sw = new Stopwatch();
            sw.Start();
            var wait = true;
            availableCash = null;

            try
            {
                Server.NeedCashInfoResult += Server_NeedCashInfoResult;
                Server.NeedCashInfo();
                while (wait)
                {
                    if (availableCash != null)
                    {
                        wait = false;
                    }
                    else if (sw.Elapsed.TotalSeconds > 10)
                    {
                        error = "Отсутствует связь с терминалом";
                        return false;
                    }
                    else
					{
                        Thread.Sleep(10);
					}
                }
            }
            finally
			{
                sw.Stop();
			}

            var cashbox = availableCash.OrderByDescending(x => x.Value);
            var amountTmp = amount;
            foreach(var cashItem in cashbox)
			{
                while (amountTmp >= cashItem.Value)
				{
                    if (cashItem.Count > 0)
					{
                        amountTmp -= cashItem.Value;
                        cashItem.Count--;
                    }
                    else
					{
                        break;
					}
				}
			}
            if (amountTmp > 0)
			{
                error = "Недостаточно купюр для выдачи";
                return false;
			}
            
            error = null;
            return true;
		}

		private void Server_NeedCashInfoResult(CashInfo[] obj)
		{
			availableCash = obj;
		}

		private void Server_PayoutResult(PayoutResult obj)
        {
            Server.PayoutResult -= Server_PayoutResult;
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

        private void TimerPay_Tick(object sender, EventArgs e)
        {
            var seconds = stopwach.Elapsed.Seconds;
            labelTime.Text = seconds.ToString();

            if (stopwach.Elapsed.TotalSeconds >= time)
            {
                stopwach.Stop();
                timerPay.Enabled = false;
                PayoutButton.Enabled = false;
                Server.PayoutResult -= Server_PayoutResult;
                labelTime.Text = DateTime.Now.ToString("dd.MM HH:mm");
                textBoxPayment.Text = "отменен";
                SetFailed();
            }
        }

        private void PayoutButton_EnabledChanged(object sender, EventArgs e)
        {
            PayoutButton.ForeColor = Color.White;
            if (PayoutButton.Enabled)
            {
                PayoutButton.BackColor = ColorConstants.BlueColor;
            }
            else
            {
                PayoutButton.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
            }
        }
    }
}
