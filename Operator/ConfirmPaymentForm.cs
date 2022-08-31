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
    public partial class ConfirmPaymentForm : Form
    {
        public ConfirmPaymentForm()
        {
            InitializeComponent();
        }

        public decimal Cash { get { return numericCash.Value; } }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (numericCash.Value > 0)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Введите сумму для выдачи");
            }
        }
    }
}
