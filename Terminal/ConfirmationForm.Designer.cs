using ComponentFactory.Krypton.Toolkit;

namespace Terminal
{
    partial class ConfirmationForm
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
            this.kryptonButtonNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.roundedPanel1 = new Terminal.Controls.RoundedPanel();
            this.labelConfirmation = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kryptonButtonNext
            // 
            this.kryptonButtonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonButtonNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kryptonButtonNext.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Italic);
            this.kryptonButtonNext.Location = new System.Drawing.Point(517, 579);
            this.kryptonButtonNext.Name = "kryptonButtonNext";
            this.kryptonButtonNext.Size = new System.Drawing.Size(270, 90);
            this.kryptonButtonNext.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButtonNext.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButtonNext.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.kryptonButtonNext.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonNext.StateCommon.Border.Rounding = 40;
            this.kryptonButtonNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonButtonNext.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonButtonNext.TabIndex = 33;
            this.kryptonButtonNext.Values.Text = "OK";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Azure;
            this.roundedPanel1.Controls.Add(this.labelConfirmation);
            this.roundedPanel1.Location = new System.Drawing.Point(277, 188);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(758, 249);
            this.roundedPanel1.TabIndex = 34;
            // 
            // labelConfirmation
            // 
            this.labelConfirmation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConfirmation.Location = new System.Drawing.Point(83, 31);
            this.labelConfirmation.Name = "labelConfirmation";
            this.labelConfirmation.Size = new System.Drawing.Size(609, 185);
            this.labelConfirmation.TabIndex = 2;
            this.labelConfirmation.Text = "Счет будет пополнен в ближайшее время";
            this.labelConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1312, 828);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.kryptonButtonNext);
            this.Name = "ConfirmationForm";
            this.Text = "Подтвержедение операции";
            this.Load += new System.EventHandler(this.Confirmation_Load);
            this.Shown += new System.EventHandler(this.ConfirmationForm_Shown);
            this.roundedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelConfirmation;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonNext;
		private Terminal.Controls.RoundedPanel roundedPanel1;
	}
}