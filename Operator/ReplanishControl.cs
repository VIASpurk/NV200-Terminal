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
using System.Windows.Forms;

namespace Operator
{
    public partial class ReplanishControl : BaseInfoControl
    {
        public ReplanishControl()
        {
            InitializeComponent();
            BackColor = Color.White;
            
            CurrentInfo.State = 1;
            CurrentInfo.TypeID = 1;
            CurrentInfo.Position = 0;
            CurrentInfo.IncomeDate = DateTime.Now;
        }

        private void PayoutButton_Click(object sender, EventArgs e)
        {
            SetCompleted();
        }

        private void SetCompleted()
		{
            CurrentInfo.State = 2;

            PayoutButton.Visible = false;
            pictureBoxReplanuish.Visible = true;

            labelPC.BackColor = ColorConstants.RedColor;
            labelSum.BackColor = ColorConstants.RedColor;
            pictureBoxReplanuish.BackColor = ColorConstants.RedColor;
            labelTime.BackColor = ColorConstants.RedColor;
        }

        private void ReplanishControl_Load(object sender, EventArgs e)
        {
            labelPC.Text = $"ПК {CurrentInfo.PCName}";
            labelSum.Text = CurrentInfo.Quantity.ToString();
            labelTime.Text = CurrentInfo.IncomeDate.ToString("dd.MM HH:mm");

            pictureBoxReplanuish.Visible = false;

            if (CurrentInfo.State != 1)
			{
                SetCompleted();
			}
        }
    }
}
