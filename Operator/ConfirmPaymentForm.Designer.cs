namespace Operator
{
    partial class ConfirmPaymentForm
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
            this.labelCash = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.numericCash = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericCash)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCash.Location = new System.Drawing.Point(60, 26);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(256, 24);
            this.labelCash.TabIndex = 0;
            this.labelCash.Text = "Введите сумму для выдачи";
            // 
            // buttonPay
            // 
            this.buttonPay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPay.Location = new System.Drawing.Point(119, 113);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(94, 23);
            this.buttonPay.TabIndex = 2;
            this.buttonPay.Text = "OK";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // numericCash
            // 
            this.numericCash.Location = new System.Drawing.Point(110, 71);
            this.numericCash.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericCash.Name = "numericCash";
            this.numericCash.Size = new System.Drawing.Size(120, 20);
            this.numericCash.TabIndex = 3;
            // 
            // ConfirmPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 148);
            this.Controls.Add(this.numericCash);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.labelCash);
            this.Name = "ConfirmPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выдача";
            ((System.ComponentModel.ISupportInitialize)(this.numericCash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.NumericUpDown numericCash;
    }
}