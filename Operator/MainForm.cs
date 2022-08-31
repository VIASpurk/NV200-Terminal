﻿using NetworkLibrary.Server;
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
    public partial class MainForm : Form
    {
        ServerHost server;
        public MainForm()
        {
            InitializeComponent();

            this.Location = new Point(Settings.Instance.WindowPositionX, Settings.Instance.WindowPositionY);
            this.Size = new Size(this.Size.Width, Settings.Instance.WindowHeight);
        }
        
        public string testCells;
        private bool ModeTechnikalBreak;

        private void StatusBoardForm_Load(object sender, EventArgs e)
        {
            server = ServerHost.StartServer();
            server.ReplenishmentRequest += Server_ReplenishmentRequest;
            server.PayoutRequest += Server_PayoutRequest;
            
            
        }

        private void Server_PayoutRequest(PayoutRequest obj)
        {
            var us = new PaymentControl();
            var width = StatusPanel.Width - StatusPanel.Padding.Left - StatusPanel.Padding.Right;
            us.Size = new Size(width, us.Height);
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
            var width = StatusPanel.Width - StatusPanel.Padding.Left - StatusPanel.Padding.Right;
            us.Size = new Size(width, us.Height);
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

        private void button1_Click(object sender, EventArgs e)
        {
            var us = new PaymentControl();
            var width = StatusPanel.Width - StatusPanel.Padding.Left - StatusPanel.Padding.Right;
            us.Size = new Size(width, us.Height);
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
            var width = StatusPanel.Width - StatusPanel.Padding.Left - StatusPanel.Padding.Right;
            us.Size = new Size(width, us.Height);
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

        

        private void TechnicalBreakButton_Click(object sender, EventArgs e)
        {
			if (ModeTechnikalBreak)
			{
				server.SetWorkingMode();
				ModeTechnikalBreak = false;
                TechnicalBreakButton.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
			else
			{
				server.SetTechnicalBreakMode();
				ModeTechnikalBreak = true;
                TechnicalBreakButton.BackColor = Color.Red;
            }
        }

        private void BalanceButton_Click(object sender, EventArgs e)
        {
            BalanceForm.ShowBalance(server);
        }
    }
}
