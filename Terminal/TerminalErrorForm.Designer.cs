namespace Terminal
{
    partial class TerminalErrorForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.roundedPanel1 = new Terminal.Controls.RoundedPanel();
			this.roundedPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.label1.Location = new System.Drawing.Point(34, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(712, 157);
			this.label1.TabIndex = 0;
			this.label1.Text = "Терминал временно не доступен";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedPanel1
			// 
			this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.roundedPanel1.BackColor = System.Drawing.Color.White;
			this.roundedPanel1.Controls.Add(this.label1);
			this.roundedPanel1.Location = new System.Drawing.Point(291, 266);
			this.roundedPanel1.Name = "roundedPanel1";
			this.roundedPanel1.Size = new System.Drawing.Size(778, 317);
			this.roundedPanel1.TabIndex = 1;
			// 
			// TerminalErrorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.ClientSize = new System.Drawing.Size(1312, 828);
			this.Controls.Add(this.roundedPanel1);
			this.Name = "TerminalErrorForm";
			this.Text = "TerminalErrorForm";
			this.roundedPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
		private Controls.RoundedPanel roundedPanel1;
	}
}