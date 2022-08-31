using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator.Controls
{
	public partial class CashTextBox : UserControl
	{
		private string emptyString = "сумма";
		
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int Cash
		{
			get 
			{
				int.TryParse(textBox1.Text, out int val);
				return val;
			}
		}

		public bool ReadOnly
		{
			get
			{
				return textBox1.ReadOnly;
			}
			set
			{
				textBox1.ReadOnly = value;
				textBox1.Visible = !value;
				label1.Visible = value;
			}
		}

		public HorizontalAlignment TextAlign
		{
			get
			{
				return textBox1.TextAlign;
			}
			set
			{
				textBox1.TextAlign = value;
			}
		}

		public new string Text
		{
			get 
			{
				if (textBox1.Text == emptyString)
				{
					return "";
				}

				return textBox1.Text;
			}
			set
			{
				textBox1.Text = value;
			}
		}

		public CashTextBox()
		{
			InitializeComponent();
			textBox1.Text = emptyString;
			textBox1.ForeColor = Color.Gray;
		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			if (textBox1.Text == emptyString)
			{
				textBox1.Text = "";
				textBox1.ForeColor = this.ForeColor;
			}
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				textBox1.Text = emptyString;
				textBox1.ForeColor = Color.Gray;
			}
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			label1.Text = textBox1.Text;
		}
	}
}
