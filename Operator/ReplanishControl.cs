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
            this.BackColor = Color.White;
            this.CurrentInfo.State = 1;
            this.CurrentInfo.TypeID = 1;
            this.CurrentInfo.Position = 0;
            this.CurrentInfo.IncomeDate = DateTime.Now;
        }

      
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

            labelPC.BackColor = ColorConstants.RedColor;
            labelSum.BackColor = ColorConstants.RedColor;
            pictureBoxReplanuish.BackColor = ColorConstants.RedColor;
            labelTime.BackColor = ColorConstants.RedColor;
        }

        private void ReplanishControl_Load(object sender, EventArgs e)
        {
            labelPC.Text = $"ПК {CurrentInfo.PCName}";
            labelSum.Text = CurrentInfo.Quantity.ToString();
            pictureBoxReplanuish.Visible = false;
            labelTime.Text = CurrentInfo.IncomeDate.ToString("dd.MM HH:mm");
        }
    }
}
