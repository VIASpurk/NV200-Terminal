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
			this.WaitTimer = new System.Windows.Forms.Timer(this.components);
			this.labelChoiseText = new System.Windows.Forms.Label();
			this.ErrorTimer = new System.Windows.Forms.Timer(this.components);
			this.tabControl1 = new Terminal.Controls.TabControlWithoutHeader();
			this.TabPageLoad = new System.Windows.Forms.TabPage();
			this.roundedPanel1 = new Terminal.Controls.RoundedPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelTimeWaiting = new System.Windows.Forms.Label();
			this.pictureBoxWaiting = new System.Windows.Forms.PictureBox();
			this.TabPageLater = new System.Windows.Forms.TabPage();
			this.labelInfoWaiting = new System.Windows.Forms.Label();
			this.TabPagePayout = new System.Windows.Forms.TabPage();
			this.PayoutLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.TabPageLoad.SuspendLayout();
			this.roundedPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaiting)).BeginInit();
			this.TabPageLater.SuspendLayout();
			this.TabPagePayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// WaitTimer
			// 
			this.WaitTimer.Interval = 1000;
			this.WaitTimer.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// labelChoiseText
			// 
			this.labelChoiseText.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelChoiseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
			this.labelChoiseText.ForeColor = System.Drawing.Color.White;
			this.labelChoiseText.Location = new System.Drawing.Point(477, 9);
			this.labelChoiseText.Name = "labelChoiseText";
			this.labelChoiseText.Size = new System.Drawing.Size(346, 41);
			this.labelChoiseText.TabIndex = 5;
			this.labelChoiseText.Text = "СНЯТИЕ";
			this.labelChoiseText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ErrorTimer
			// 
			this.ErrorTimer.Interval = 1000;
			this.ErrorTimer.Tick += new System.EventHandler(this.ErrorTimer_Tick);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.TabPageLoad);
			this.tabControl1.Controls.Add(this.TabPageLater);
			this.tabControl1.Controls.Add(this.TabPagePayout);
			this.tabControl1.ItemSize = new System.Drawing.Size(50, 18);
			this.tabControl1.Location = new System.Drawing.Point(12, 118);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1288, 636);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 7;
			this.tabControl1.TabStop = false;
			// 
			// TabPageLoad
			// 
			this.TabPageLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.TabPageLoad.Controls.Add(this.roundedPanel1);
			this.TabPageLoad.Location = new System.Drawing.Point(4, 22);
			this.TabPageLoad.Name = "TabPageLoad";
			this.TabPageLoad.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageLoad.Size = new System.Drawing.Size(1280, 610);
			this.TabPageLoad.TabIndex = 0;
			this.TabPageLoad.Text = "крутилка";
			// 
			// roundedPanel1
			// 
			this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.roundedPanel1.BackColor = System.Drawing.Color.White;
			this.roundedPanel1.Controls.Add(this.label2);
			this.roundedPanel1.Controls.Add(this.label1);
			this.roundedPanel1.Controls.Add(this.labelTimeWaiting);
			this.roundedPanel1.Controls.Add(this.pictureBoxWaiting);
			this.roundedPanel1.Location = new System.Drawing.Point(214, 111);
			this.roundedPanel1.Name = "roundedPanel1";
			this.roundedPanel1.Size = new System.Drawing.Size(879, 337);
			this.roundedPanel1.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.label2.Location = new System.Drawing.Point(328, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(385, 31);
			this.label2.TabIndex = 7;
			this.label2.Text = "ПОЖАЛУЙСТА, ПОДОЖДИТЕ";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.label1.Location = new System.Drawing.Point(238, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(633, 55);
			this.label1.TabIndex = 6;
			this.label1.Text = "ВЫПОЛНЕНИЕ ОПЕРАЦИИ";
			// 
			// labelTimeWaiting
			// 
			this.labelTimeWaiting.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelTimeWaiting.AutoSize = true;
			this.labelTimeWaiting.BackColor = System.Drawing.Color.Transparent;
			this.labelTimeWaiting.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTimeWaiting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.labelTimeWaiting.Location = new System.Drawing.Point(96, 147);
			this.labelTimeWaiting.Name = "labelTimeWaiting";
			this.labelTimeWaiting.Size = new System.Drawing.Size(57, 43);
			this.labelTimeWaiting.TabIndex = 3;
			this.labelTimeWaiting.Text = "60";
			// 
			// pictureBoxWaiting
			// 
			this.pictureBoxWaiting.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBoxWaiting.Image = global::Terminal.Properties.Resources.hug;
			this.pictureBoxWaiting.Location = new System.Drawing.Point(16, 70);
			this.pictureBoxWaiting.Name = "pictureBoxWaiting";
			this.pictureBoxWaiting.Size = new System.Drawing.Size(208, 190);
			this.pictureBoxWaiting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxWaiting.TabIndex = 2;
			this.pictureBoxWaiting.TabStop = false;
			// 
			// TabPageLater
			// 
			this.TabPageLater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.TabPageLater.Controls.Add(this.labelInfoWaiting);
			this.TabPageLater.Location = new System.Drawing.Point(4, 22);
			this.TabPageLater.Name = "TabPageLater";
			this.TabPageLater.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageLater.Size = new System.Drawing.Size(1280, 610);
			this.TabPageLater.TabIndex = 1;
			this.TabPageLater.Text = "позднее";
			// 
			// labelInfoWaiting
			// 
			this.labelInfoWaiting.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelInfoWaiting.AutoSize = true;
			this.labelInfoWaiting.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelInfoWaiting.ForeColor = System.Drawing.Color.White;
			this.labelInfoWaiting.Location = new System.Drawing.Point(326, 252);
			this.labelInfoWaiting.Name = "labelInfoWaiting";
			this.labelInfoWaiting.Size = new System.Drawing.Size(657, 55);
			this.labelInfoWaiting.TabIndex = 4;
			this.labelInfoWaiting.Text = "Попробуйте повторить позднее";
			// 
			// TabPagePayout
			// 
			this.TabPagePayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.TabPagePayout.Controls.Add(this.PayoutLabel);
			this.TabPagePayout.Controls.Add(this.label3);
			this.TabPagePayout.Location = new System.Drawing.Point(4, 22);
			this.TabPagePayout.Name = "TabPagePayout";
			this.TabPagePayout.Padding = new System.Windows.Forms.Padding(3);
			this.TabPagePayout.Size = new System.Drawing.Size(1280, 610);
			this.TabPagePayout.TabIndex = 2;
			this.TabPagePayout.Text = "выплата";
			// 
			// PayoutLabel
			// 
			this.PayoutLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PayoutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PayoutLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PayoutLabel.ForeColor = System.Drawing.Color.White;
			this.PayoutLabel.Location = new System.Drawing.Point(677, 198);
			this.PayoutLabel.Name = "PayoutLabel";
			this.PayoutLabel.Size = new System.Drawing.Size(188, 55);
			this.PayoutLabel.TabIndex = 6;
			this.PayoutLabel.Text = "0";
			this.PayoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(322, 198);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(347, 55);
			this.label3.TabIndex = 5;
			this.label3.Text = "Сумма к выдаче";
			// 
			// WaitingPaymentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.ClientSize = new System.Drawing.Size(1312, 828);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.labelChoiseText);
			this.Name = "WaitingPaymentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Подтвержедение операции";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WaitingPaymentForm_FormClosing);
			this.Shown += new System.EventHandler(this.ConfirmationForm_Shown);
			this.tabControl1.ResumeLayout(false);
			this.TabPageLoad.ResumeLayout(false);
			this.roundedPanel1.ResumeLayout(false);
			this.roundedPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaiting)).EndInit();
			this.TabPageLater.ResumeLayout(false);
			this.TabPageLater.PerformLayout();
			this.TabPagePayout.ResumeLayout(false);
			this.TabPagePayout.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer WaitTimer;
        private System.Windows.Forms.PictureBox pictureBoxWaiting;
        private System.Windows.Forms.Label labelTimeWaiting;
        private System.Windows.Forms.Label labelInfoWaiting;
		private System.Windows.Forms.Label labelChoiseText;
		private System.Windows.Forms.Label label1;
		private Controls.TabControlWithoutHeader tabControl1;
		private System.Windows.Forms.TabPage TabPageLoad;
		private System.Windows.Forms.TabPage TabPageLater;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage TabPagePayout;
		private System.Windows.Forms.Label PayoutLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Timer ErrorTimer;
		private Controls.RoundedPanel roundedPanel1;
	}
}