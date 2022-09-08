namespace Terminal
{
    partial class DebugForm
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
            this.Depositing = new System.Windows.Forms.Button();
            this.DebugClose = new System.Windows.Forms.Button();
            this.DebugtextBox = new System.Windows.Forms.TextBox();
            this.buttonIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Depositing
            // 
            this.Depositing.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Depositing.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.Depositing.Location = new System.Drawing.Point(512, 71);
            this.Depositing.Name = "Depositing";
            this.Depositing.Size = new System.Drawing.Size(147, 40);
            this.Depositing.TabIndex = 1;
            this.Depositing.Text = "Далее";
            this.Depositing.UseVisualStyleBackColor = true;
            this.Depositing.Click += new System.EventHandler(this.Depositing_Click);
            // 
            // DebugClose
            // 
            this.DebugClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DebugClose.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.DebugClose.Location = new System.Drawing.Point(24, 71);
            this.DebugClose.Name = "DebugClose";
            this.DebugClose.Size = new System.Drawing.Size(147, 40);
            this.DebugClose.TabIndex = 2;
            this.DebugClose.Text = "Отмена";
            this.DebugClose.UseVisualStyleBackColor = true;
            this.DebugClose.Click += new System.EventHandler(this.DebugClose_Click);
            // 
            // DebugtextBox
            // 
            this.DebugtextBox.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.DebugtextBox.ForeColor = System.Drawing.Color.Gray;
            this.DebugtextBox.Location = new System.Drawing.Point(200, 75);
            this.DebugtextBox.Name = "DebugtextBox";
            this.DebugtextBox.Size = new System.Drawing.Size(306, 39);
            this.DebugtextBox.TabIndex = 3;
            this.DebugtextBox.Text = "Добавьте сумму для теста";
            this.DebugtextBox.Enter += new System.EventHandler(this.DebugtextBox_Enter);
            // 
            // buttonIn
            // 
            this.buttonIn.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.buttonIn.Location = new System.Drawing.Point(255, 134);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(147, 38);
            this.buttonIn.TabIndex = 4;
            this.buttonIn.Text = "+1000";
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(686, 192);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.DebugtextBox);
            this.Controls.Add(this.DebugClose);
            this.Controls.Add(this.Depositing);
            this.Name = "DebugForm";
            this.Text = "Отладка";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Depositing;
        private System.Windows.Forms.Button DebugClose;
        private System.Windows.Forms.TextBox DebugtextBox;
        private System.Windows.Forms.Button buttonIn;
	}
}