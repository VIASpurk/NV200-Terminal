using NetworkLibrary.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator
{
    public partial class StatusBoardForm : Form
    {
        ServerHost server;
        public StatusBoardForm()
        {
            InitializeComponent();
        }
        
        public string testCells;
        private void StatusBoardForm_Load(object sender, EventArgs e)
        {
            server = ServerHost.StartServer();
            server.ReplenishmentRequest += Server_ReplenishmentRequest;
            server.PayoutRequest += Server_PayoutRequest;
        }

        private void Server_PayoutRequest(PayoutRequest obj)
        {
            var us = new PaymentControl();
            us.NamePC = obj.PCName;
            us.server = server;
            
            List<Control> list = new List<Control>(20);
            foreach (Control control in StatusPanel.Controls)
            {
                list.Add(control);
            }

            list.Insert(0, us);
            this.Invoke(new Action(() =>
            {
                StatusPanel.Controls.Clear();
                StatusPanel.Controls.AddRange(list.ToArray());
            }));
        }

        private void Server_ReplenishmentRequest(ReplenishmentData obj)
        {
            
           
            var us = new ReplanishControl();
            us.NamePC = obj.PCName;
            us.server = server;
            us.Cash = obj.Quantity;
            List<Control> list = new List<Control>(20);
            foreach (Control control in StatusPanel.Controls)
            {
                list.Add(control);
            }

            list.Insert(0, us);

            this.Invoke(new Action(() =>
            {
                StatusPanel.Controls.Clear();
                StatusPanel.Controls.AddRange(list.ToArray());
            }));
        }

        /*  private void Server_PaymentRequest(object sender, PaymentRequestEventArgs e)
         {

              var us = new PaymentControl();
               us.NamePC = e.PCName;
               us.server = server;
               List<Control> list = new List<Control>(20);
               foreach (Control control in StatusPanel.Controls)
               {
                   list.Add(control);
               }

               list.Insert(0, us);
               this.Invoke(new Action(() =>
               {
                   StatusPanel.Controls.Clear();
                   StatusPanel.Controls.AddRange(list.ToArray());
               }));


        }*/

       /* private void Server_ReplenishmentRequest(object sender, ReplenishmentRequestEventArgs e)
        {
           // var namePC = e.PCName;
           
            var us = new ReplanishControl();
            us.NamePC = e.PCName;
            us.server = server;
            us.Cash = e.Quantity;
            List<Control> list = new List<Control>(20);
            foreach (Control control in StatusPanel.Controls)
            {
                list.Add(control);
            }

            list.Insert(0, us);

            this.Invoke(new Action(() =>
            {
                StatusPanel.Controls.Clear();
                StatusPanel.Controls.AddRange(list.ToArray());
            }));




    }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var us = new PaymentControl();
            us.NamePC = 1;
            us.server = server;
            List<Control> list = new List<Control>(20);
            foreach (Control control in StatusPanel.Controls)
            {
                list.Add(control);
            }

            list.Insert(0, us);
            StatusPanel.Controls.Clear();
            StatusPanel.Controls.AddRange(list.ToArray());



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var us = new ReplanishControl();
            us.NamePC = 1;
            us.server = server;
            us.Cash = 100;
            List<Control> list = new List<Control>(20);
            foreach (Control control in StatusPanel.Controls)
            {
                list.Add(control);            
            }

            list.Insert(0, us);
            StatusPanel.Controls.Clear();
            StatusPanel.Controls.AddRange(list.ToArray());
            

        }

        private void StatusBoardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Instance.WindowHeight = this.Size.Height;
            Settings.Instance.WindowPositionX = this.Location.X;
            Settings.Instance.WindowPositionY = this.Location.Y;
            Settings.Instance.SaveConfig();
        }
    }
}
