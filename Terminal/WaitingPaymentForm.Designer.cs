namespace Terminal
{
    partial class WaitingPaymentForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxWaiting = new System.Windows.Forms.PictureBox();
            this.labelTimeWaiting = new System.Windows.Forms.Label();
            this.labelInfoWaiting = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaiting)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxWaiting
            // 
            this.pictureBoxWaiting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxWaiting.Image = global::Terminal.Properties.Resources.hug;
            this.pictureBoxWaiting.Location = new System.Drawing.Point(373, 117);
            this.pictureBoxWaiting.Name = "pictureBoxWaiting";
            this.pictureBoxWaiting.Size = new System.Drawing.Size(521, 526);
            this.pictureBoxWaiting.TabIndex = 2;
            this.pictureBoxWaiting.TabStop = false;
            // 
            // labelTimeWaiting
            // 
            this.labelTimeWaiting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimeWaiting.AutoSize = true;
            this.labelTimeWaiting.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeWaiting.Location = new System.Drawing.Point(580, 336);
            this.labelTimeWaiting.Name = "labelTimeWaiting";
            this.labelTimeWaiting.Size = new System.Drawing.Size(96, 73);
            this.labelTimeWaiting.TabIndex = 3;
            this.labelTimeWaiting.Text = "60";
            // 
            // labelInfoWaiting
            // 
            this.labelInfoWaiting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfoWaiting.AutoSize = true;
            this.labelInfoWaiting.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoWaiting.Location = new System.Drawing.Point(303, 349);
            this.labelInfoWaiting.Name = "labelInfoWaiting";
            this.labelInfoWaiting.Size = new System.Drawing.Size(690, 55);
            this.labelInfoWaiting.TabIndex = 4;
            this.labelInfoWaiting.Text = "Попробуйте повторить позднее";
            // 
            // WaitingPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1312, 828);
            this.Controls.Add(this.labelInfoWaiting);
            this.Controls.Add(this.labelTimeWaiting);
            this.Controls.Add(this.pictureBoxWaiting);
            this.Name = "WaitingPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подтвержедение операции";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WaitingPaymentForm_FormClosing);
            this.Load += new System.EventHandler(this.WaitingPaymentForm_Load);
            this.Shown += new System.EventHandler(this.ConfirmationForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaiting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxWaiting;
        private System.Windows.Forms.Label labelTimeWaiting;
        private System.Windows.Forms.Label labelInfoWaiting;
    }
}