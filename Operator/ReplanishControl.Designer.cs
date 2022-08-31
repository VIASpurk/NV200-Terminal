namespace Operator
{
    partial class ReplanishControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.labelTime = new System.Windows.Forms.Label();
			this.labelSum = new System.Windows.Forms.Label();
			this.labelPC = new System.Windows.Forms.Label();
			this.PayoutButton = new System.Windows.Forms.Button();
			this.pictureBoxReplanuish = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxReplanuish)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTime.BackColor = System.Drawing.SystemColors.Control;
			this.labelTime.Location = new System.Drawing.Point(153, 2);
			this.labelTime.Name = "labelTime";
			this.labelTime.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.labelTime.Size = new System.Drawing.Size(72, 20);
			this.labelTime.TabIndex = 8;
			this.labelTime.Text = "10.08 12:00";
			this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSum
			// 
			this.labelSum.BackColor = System.Drawing.SystemColors.Control;
			this.labelSum.Location = new System.Drawing.Point(46, 2);
			this.labelSum.Name = "labelSum";
			this.labelSum.Size = new System.Drawing.Size(50, 20);
			this.labelSum.TabIndex = 11;
			this.labelSum.Text = "150000";
			this.labelSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelPC
			// 
			this.labelPC.BackColor = System.Drawing.SystemColors.Control;
			this.labelPC.Location = new System.Drawing.Point(2, 2);
			this.labelPC.Name = "labelPC";
			this.labelPC.Size = new System.Drawing.Size(42, 20);
			this.labelPC.TabIndex = 10;
			this.labelPC.Text = "ПК 15";
			this.labelPC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PayoutButton
			// 
			this.PayoutButton.BackColor = System.Drawing.Color.Transparent;
			this.PayoutButton.Location = new System.Drawing.Point(98, 1);
			this.PayoutButton.Name = "PayoutButton";
			this.PayoutButton.Size = new System.Drawing.Size(53, 22);
			this.PayoutButton.TabIndex = 9;
			this.PayoutButton.Text = "Внести";
			this.PayoutButton.UseVisualStyleBackColor = false;
			this.PayoutButton.Click += new System.EventHandler(this.PayoutButton_Click);
			// 
			// pictureBoxReplanuish
			// 
			this.pictureBoxReplanuish.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBoxReplanuish.Image = global::Operator.Properties.Resources.icons8_ok_483;
			this.pictureBoxReplanuish.Location = new System.Drawing.Point(98, 2);
			this.pictureBoxReplanuish.Name = "pictureBoxReplanuish";
			this.pictureBoxReplanuish.Size = new System.Drawing.Size(53, 20);
			this.pictureBoxReplanuish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxReplanuish.TabIndex = 12;
			this.pictureBoxReplanuish.TabStop = false;
			// 
			// ReplanishControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.Controls.Add(this.labelTime);
			this.Controls.Add(this.labelSum);
			this.Controls.Add(this.labelPC);
			this.Controls.Add(this.PayoutButton);
			this.Controls.Add(this.pictureBoxReplanuish);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "ReplanishControl";
			this.Size = new System.Drawing.Size(227, 23);
			this.Load += new System.EventHandler(this.ReplanishControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxReplanuish)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelPC;
        private System.Windows.Forms.Button PayoutButton;
        private System.Windows.Forms.PictureBox pictureBoxReplanuish;
    }
}
