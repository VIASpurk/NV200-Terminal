namespace Operator
{
    partial class MainForm
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
			this.button1 = new System.Windows.Forms.Button();
			this.StatusPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.button2 = new System.Windows.Forms.Button();
			this.TechnicalBreakButton = new System.Windows.Forms.Button();
			this.BalanceButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(186, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(38, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "+pay";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// StatusPanel
			// 
			this.StatusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.StatusPanel.BackColor = System.Drawing.Color.White;
			this.StatusPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.StatusPanel.Location = new System.Drawing.Point(11, 38);
			this.StatusPanel.Name = "StatusPanel";
			this.StatusPanel.Padding = new System.Windows.Forms.Padding(1);
			this.StatusPanel.Size = new System.Drawing.Size(250, 220);
			this.StatusPanel.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(225, 9);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(36, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "+repl";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// TechnicalBreakButton
			// 
			this.TechnicalBreakButton.Location = new System.Drawing.Point(11, 9);
			this.TechnicalBreakButton.Name = "TechnicalBreakButton";
			this.TechnicalBreakButton.Size = new System.Drawing.Size(88, 23);
			this.TechnicalBreakButton.TabIndex = 6;
			this.TechnicalBreakButton.Text = "тех перерыв";
			this.TechnicalBreakButton.Click += new System.EventHandler(this.TechnicalBreakButton_Click);
			// 
			// BalanceButton
			// 
			this.BalanceButton.Location = new System.Drawing.Point(105, 9);
			this.BalanceButton.Name = "BalanceButton";
			this.BalanceButton.Size = new System.Drawing.Size(60, 23);
			this.BalanceButton.TabIndex = 7;
			this.BalanceButton.Text = "баланс";
			this.BalanceButton.UseVisualStyleBackColor = true;
			this.BalanceButton.Click += new System.EventHandler(this.BalanceButton_Click);
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(272, 269);
			this.Controls.Add(this.BalanceButton);
			this.Controls.Add(this.TechnicalBreakButton);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.StatusPanel);
			this.Controls.Add(this.button1);
			this.Location = new System.Drawing.Point(10, 10);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(280, 800);
			this.MinimumSize = new System.Drawing.Size(280, 300);
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(8);
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Терминал";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatusBoardForm_FormClosing);
			this.Load += new System.EventHandler(this.StatusBoardForm_Load);
			this.ResumeLayout(false);

		}

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel StatusPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button TechnicalBreakButton;
        private System.Windows.Forms.Button BalanceButton;
    }
}