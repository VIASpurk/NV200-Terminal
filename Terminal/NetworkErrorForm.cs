using NetworkLibrary;
using NetworkLibrary.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerminalLibrary;

namespace Terminal
{
    public partial class NetworkErrorForm : Form
    {
        private IServerProxy serverProxy;

        private NetworkErrorForm()
        {
            InitializeComponent();

            if (!SettingsTerminal.Instance.Debug)
            {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
            }
        }

        public static IServerProxy Reconnect(IWin32Window owner, bool showWindowFirst = false)
		{
            var networkErrorForm = new NetworkErrorForm();

            if (showWindowFirst)
			{
                networkErrorForm.ShowDialog(owner);
                return networkErrorForm.serverProxy;
            }

            try
            {
                return ClientConnection.ConnectToServer(SettingsTerminal.Instance.NameServer);
            }
            catch
			{
                networkErrorForm.ShowDialog(owner);
                return networkErrorForm.serverProxy;
            }
		}

        private async Task Connect()
		{
            var address = SettingsTerminal.Instance.NameServer;

            while (serverProxy == null && !IsDisposed)
			{
                try
                {
                    serverProxy = ClientConnection.ConnectToServer(address);
                }
                catch
                {
                    await Task.Delay(1000);
                }
            }

            if (!IsDisposed)
            {
                Invoke(new Action(() => Close()));
            }
        }

        private void NetworkErrorForm_Shown(object sender, EventArgs e)
        {
            Refresh();
			Task.Run(Connect);
        }
    }
}
