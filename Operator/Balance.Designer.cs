namespace Operator
{
    partial class BalanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.labelBalance = new System.Windows.Forms.Label();
			this.CashInfoLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelBalance
			// 
			this.labelBalance.AutoSize = true;
			this.labelBalance.Location = new System.Drawing.Point(53, 22);
			this.labelBalance.Name = "labelBalance";
			this.labelBalance.Size = new System.Drawing.Size(229, 13);
			this.labelBalance.TabIndex = 1;
			this.labelBalance.Text = "Доступные средства к выдаче терминалом";
			// 
			// CashInfoLabel
			// 
			this.CashInfoLabel.Location = new System.Drawing.Point(53, 76);
			this.CashInfoLabel.Name = "CashInfoLabel";
			this.CashInfoLabel.Size = new System.Drawing.Size(269, 137);
			this.CashInfoLabel.TabIndex = 2;
			// 
			// BalanceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 257);
			this.Controls.Add(this.CashInfoLabel);
			this.Controls.Add(this.labelBalance);
			this.Name = "BalanceForm";
			this.Text = "Баланс";
			this.Shown += new System.EventHandler(this.BalanceForm_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBalance;
		private System.Windows.Forms.Label CashInfoLabel;
	}
}