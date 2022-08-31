using NetworkLibrary.Server;
using System;
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
    public partial class BalanceForm : Form
    {
        private ServerHost server;

        public BalanceForm()
        {
            InitializeComponent();
        }

        public static void ShowBalance(ServerHost server)
        {
            using (BalanceForm frm = new BalanceForm())
            {
                frm.server = server;
                frm.ShowDialog();
            }
        }

		private void BalanceForm_Shown(object sender, EventArgs e)
		{
			server.NeedCashInfoResult += Server_NeedCashInfoResult;
            server.NeedCashInfo();
        }

		private void Server_NeedCashInfoResult(NetworkLibrary.CashInfo[] info)
		{
            server.NeedCashInfoResult -= Server_NeedCashInfoResult;
            StringBuilder sb = new StringBuilder();
            int amount = 0;
            foreach (var row in info)
			{
                sb.AppendLine($"{row.Value} * {row.Count} = {row.Value * row.Count}");
                amount += row.Value * row.Count;
            }
            sb.AppendLine();
            sb.AppendLine($"Всего: {amount}");

            this.Invoke(new Action(() => CashInfoLabel.Text = sb.ToString()));
        }
	}
}
