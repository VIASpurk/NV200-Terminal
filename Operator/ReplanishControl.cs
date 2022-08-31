﻿using NetworkLibrary.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator
{
    public partial class ReplanishControl : UserControl
    {
        public ReplanishControl()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }

        public int NamePC { get; set; }

        public int Cash { get; set; }
        public ServerHost server { get; set; }

        private void PayoutButton_Click(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("dd.MM HH:mm");
            SetCompleted();
        }

        private void SetCompleted()
		{
            PayoutButton.Visible = false;
            pictureBoxReplanuish.Visible = true;

            labelPC.BackColor = Color.PaleVioletRed;
            labelSum.BackColor = Color.PaleVioletRed;
            pictureBoxReplanuish.BackColor = Color.PaleVioletRed;
            labelTime.BackColor = Color.PaleVioletRed;
        }

        private void ReplanishControl_Load(object sender, EventArgs e)
        {
            labelPC.Text = $"ПК {NamePC}";
            labelSum.Text = Cash.ToString();
            pictureBoxReplanuish.Visible = false;
        }
    }
}
