using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
    public partial class DebugForm : Form
    {
        private int testCash;
        public String textCash = "";
        public DebugForm()
        {
            InitializeComponent();
        }

        private void DebugClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void Depositing_Click(object sender, EventArgs e)
        {

           int.TryParse(DebugtextBox.Text, out testCash);
           

        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            int testCash = 1000;
            
                try
                {
                    DebugtextBox.Text = testCash.ToString();
                }
                catch
                {
                    MessageBox.Show("Вводите только числа без запятых");
                }
          

        }

        private void DebugtextBox_Enter(object sender, EventArgs e)
        {
            if (DebugtextBox.Text == "Добавьте сумму для теста")
            {
                DebugtextBox.Text = "";
            }
        }
        public int GetCash()
        {
            return testCash;
        }

        
    }
}
