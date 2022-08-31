namespace Operator
{
    partial class PaymentControl
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
			this.components = new System.ComponentModel.Container();
			this.labelPC = new System.Windows.Forms.Label();
			this.PayoutButton = new System.Windows.Forms.Button();
			this.labelTime = new System.Windows.Forms.Label();
			this.timerPay = new System.Windows.Forms.Timer(this.components);
			this.pictureBoxPay = new System.Windows.Forms.PictureBox();
			this.ErrorToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.textBoxPayment = new Operator.Controls.CashTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPay)).BeginInit();
			this.SuspendLayout();
			// 
			// labelPC
			// 
			this.labelPC.BackColor = System.Drawing.SystemColors.Control;
			this.labelPC.Location = new System.Drawing.Point(2, 2);
			this.labelPC.Name = "labelPC";
			this.labelPC.Size = new System.Drawing.Size(42, 20);
			this.labelPC.TabIndex = 6;
			this.labelPC.Text = "ПК 15";
			this.labelPC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PayoutButton
			// 
			this.PayoutButton.BackColor = System.Drawing.Color.Transparent;
			this.PayoutButton.Location = new System.Drawing.Point(98, 1);
			this.PayoutButton.Name = "PayoutButton";
			this.PayoutButton.Size = new System.Drawing.Size(53, 22);
			this.PayoutButton.TabIndex = 5;
			this.PayoutButton.Text = "Выдать";
			this.PayoutButton.UseVisualStyleBackColor = false;
			this.PayoutButton.Click += new System.EventHandler(this.PayoutButton_Click);
			// 
			// labelTime
			// 
			this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTime.BackColor = System.Drawing.SystemColors.Control;
			this.labelTime.Location = new System.Drawing.Point(153, 2);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(72, 20);
			this.labelTime.TabIndex = 4;
			this.labelTime.Text = "10.08 12:00";
			this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// timerPay
			// 
			this.timerPay.Interval = 1000;
			this.timerPay.Tick += new System.EventHandler(this.timerPay_Tick);
			// 
			// pictureBoxPay
			// 
			this.pictureBoxPay.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBoxPay.Image = global::Operator.Properties.Resources.icons8_ok_483;
			this.pictureBoxPay.Location = new System.Drawing.Point(98, 2);
			this.pictureBoxPay.Name = "pictureBoxPay";
			this.pictureBoxPay.Size = new System.Drawing.Size(53, 20);
			this.pictureBoxPay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxPay.TabIndex = 8;
			this.pictureBoxPay.TabStop = false;
			// 
			// textBoxPayment
			// 
			this.textBoxPayment.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxPayment.Location = new System.Drawing.Point(46, 2);
			this.textBoxPayment.MaximumSize = new System.Drawing.Size(2, 20);
			this.textBoxPayment.MinimumSize = new System.Drawing.Size(50, 20);
			this.textBoxPayment.Name = "textBoxPayment";
			this.textBoxPayment.ReadOnly = false;
			this.textBoxPayment.Size = new System.Drawing.Size(50, 20);
			this.textBoxPayment.TabIndex = 7;
			this.textBoxPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// PaymentControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.Controls.Add(this.textBoxPayment);
			this.Controls.Add(this.labelTime);
			this.Controls.Add(this.labelPC);
			this.Controls.Add(this.PayoutButton);
			this.Controls.Add(this.pictureBoxPay);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "PaymentControl";
			this.Size = new System.Drawing.Size(227, 23);
			this.Load += new System.EventHandler(this.PaymentControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPay)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelPC;
        private System.Windows.Forms.Button PayoutButton;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerPay;
        private Controls.CashTextBox textBoxPayment;
        private System.Windows.Forms.PictureBox pictureBoxPay;
        private System.Windows.Forms.ToolTip ErrorToolTip;
    }
}
