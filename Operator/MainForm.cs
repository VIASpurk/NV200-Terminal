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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Zyan.Communication.Protocols.Tcp.DuplexChannel;
using static System.Collections.Specialized.BitVector32;

namespace Operator
{
    public partial class MainForm : Form
    {
        ServerHost server;
        private bool loadingLog = false;

        public MainForm()
        {
            InitializeComponent();
            var x = Settings.Instance.WindowPositionX;
            var y = Settings.Instance.WindowPositionY;
            

            if (x > Screen.PrimaryScreen.Bounds.Width)
            {
                x = Screen.PrimaryScreen.Bounds.Width - Width;
            }
            else if (x < 0)
            {
                x = 0;
            }

            if (y > Screen.PrimaryScreen.Bounds.Height)
            {
                y = Screen.PrimaryScreen.Bounds.Height - Height;
            }
            else if (y < 0)
            { 
                y = 0; 
            }

            this.Location = new Point(x, y);
            this.Size = new Size(this.Size.Width, Settings.Instance.WindowHeight);
            
            if (Settings.Instance.Debug)
            {
                button1.Visible = true;
                button2.Visible = true;
            }
        }
        
        private bool ModeTechnikalBreak;

        private void StatusBoardForm_Load(object sender, EventArgs e)
        {
            var list = new List<BaseInfoControl>(20);

            loadingLog = true;
            var listAction = Logger.Instance.ReadLog();

            int i = 0;
            foreach (var item in listAction.OrderBy(x => x.Position))
            {
                BaseInfoControl us = null;

                switch (item.TypeID)
				{
                    case 1:
                        us = new ReplanishControl();
                        us.CurrentInfo.State = item.State;
                        break;
                    case 2:
                        us = new PaymentControl();
                        us.CurrentInfo.State = item.State != 2 ? 3 : item.State;
                        break;
                    default:
                        continue;
				}

                us.CurrentInfo.PCName = item.PCName;
                us.CurrentInfo.Quantity = item.Quantity;
                us.CurrentInfo.IncomeDate = item.IncomeDate;
                us.CurrentInfo.Position = i++;

                list.Add(us);
            }

            list.OrderByDescending(x => x.CurrentInfo.Position).ToList().ForEach(x => AddNewControl(x));
            loadingLog = false;

            server = ServerHost.StartServer();
            server.ReplenishmentRequest += Server_ReplenishmentRequest;
            server.PayoutRequest += Server_PayoutRequest;

            list.ForEach(x => x.Server = this.server);
        }

        private void AddNewControl(BaseInfoControl control)
		{
            int maxCount = 20;
            var width = StatusPanel.Width - StatusPanel.Padding.Left - StatusPanel.Padding.Right;
            control.Size = new Size(width, control.Height);

			List<BaseInfoControl> list = new List<BaseInfoControl>(maxCount)
			{
				control
			};
			control.CurrentInfo.StateChanged += CurrentInfo_StateChanged;

            int i = 0;
            foreach (BaseInfoControl item in StatusPanel.Controls)
            {
                if (i < maxCount - 1)
                {
                    list.Add(item);
                }
                else
				{
                    item.CurrentInfo.StateChanged -= CurrentInfo_StateChanged;
                }
                i++;
            }

            if (InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    StatusPanel.Controls.Clear();
                    StatusPanel.Controls.AddRange(list.ToArray());
                }));
            }
            else
			{
                StatusPanel.Controls.Clear();
                StatusPanel.Controls.AddRange(list.ToArray());
            }
        }

		private void CurrentInfo_StateChanged()
		{
            if (loadingLog)
			{
                return;
			}
            WriteControlsInLog();
		}

		private void Server_PayoutRequest(PayoutRequest obj)
        {
            var us = new PaymentControl();
            us.CurrentInfo.PCName = obj.PCName;
            us.Server = server;

            AddNewControl(us);
            WriteControlsInLog();
        }

        private void Server_ReplenishmentRequest(ReplenishmentData obj)
        {
            var us = new ReplanishControl();
            us.CurrentInfo.PCName = obj.PCName;
            us.CurrentInfo.Quantity = obj.Quantity;
            us.Server = server;

            AddNewControl(us);
            WriteControlsInLog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var us = new PaymentControl();
            us.CurrentInfo.PCName = 1;
            us.Server = server;

            AddNewControl(us);
            WriteControlsInLog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var us = new ReplanishControl();
            us.CurrentInfo.PCName = 1;
            us.Server = server;

            AddNewControl(us);
            WriteControlsInLog();
        }

        private void StatusBoardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteControlsInLog();

            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show(this, "Вы точно хотите закрыть программу,", "Закрытие программы", messageBoxButtons);
            if (result == DialogResult.Yes)
            {
                Settings.Instance.WindowHeight = this.Size.Height;
                Settings.Instance.WindowPositionX = this.Location.X;
                Settings.Instance.WindowPositionY = this.Location.Y;
                Settings.Instance.SaveConfig();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void WriteControlsInLog()
        {
            List<ActionInfo> list = new List<ActionInfo>(20);
            foreach (BaseInfoControl control in StatusPanel.Controls)
            {
                list.Add(control.CurrentInfo); 
            }

            Logger.Instance.WriteLog(list);
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
