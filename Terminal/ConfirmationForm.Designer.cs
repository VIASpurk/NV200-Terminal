﻿using ComponentFactory.Krypton.Toolkit;

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
            this.labelConfirmation = new System.Windows.Forms.Label();
            this.kryptonButtonNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelConfirmation
            // 
            this.labelConfirmation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConfirmation.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConfirmation.Location = new System.Drawing.Point(242, 234);
            this.labelConfirmation.Name = "labelConfirmation";
            this.labelConfirmation.Size = new System.Drawing.Size(879, 178);
            this.labelConfirmation.TabIndex = 2;
            this.labelConfirmation.Text = "Ожидайте пополнение счета";
            this.labelConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonButtonNext
            // 
            this.kryptonButtonNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButtonNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kryptonButtonNext.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Italic);
            this.kryptonButtonNext.Location = new System.Drawing.Point(433, 582);
            this.kryptonButtonNext.Name = "kryptonButtonNext";
            this.kryptonButtonNext.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonButtonNext.OverrideDefault.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.kryptonButtonNext.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 18.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.kryptonButtonNext.Size = new System.Drawing.Size(467, 74);
            this.kryptonButtonNext.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.kryptonButtonNext.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonButtonNext.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.kryptonButtonNext.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.kryptonButtonNext.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonNext.StateCommon.Border.Rounding = 18;
            this.kryptonButtonNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.kryptonButtonNext.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButtonNext.StateNormal.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.kryptonButtonNext.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonNext.StateNormal.Border.Rounding = 18;
            this.kryptonButtonNext.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 18.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.kryptonButtonNext.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButtonNext.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonButtonNext.TabIndex = 33;
            this.kryptonButtonNext.Values.Text = "OK";
            // 
            // kryptonLabel
            // 
            this.kryptonLabel.AutoSize = false;
            this.kryptonLabel.Location = new System.Drawing.Point(375, -1);
            this.kryptonLabel.Name = "kryptonLabel";
            this.kryptonLabel.Size = new System.Drawing.Size(734, 219);
            this.kryptonLabel.StateNormal.ShortText.Font = new System.Drawing.Font("Onyx", 28.25F, System.Drawing.FontStyle.Italic);
            this.kryptonLabel.StateNormal.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonLabel.StateNormal.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.EllipsisWord;
            this.kryptonLabel.TabIndex = 34;
            this.kryptonLabel.Values.Text = "Вставьте купюры в купюроприемник. Дождитесь пока в поле \"Внесенная сумма\"  появит" +
    "ся сумма внесенных Вами денег";
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1312, 828);
            this.Controls.Add(this.kryptonButtonNext);
            this.Controls.Add(this.kryptonLabel);
            this.Controls.Add(this.labelConfirmation);
            this.Name = "ConfirmationForm";
            this.Text = "Подтвержедение операции";
            this.Load += new System.EventHandler(this.Confirmation_Load);
            this.Shown += new System.EventHandler(this.ConfirmationForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelConfirmation;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonNext;
        private KryptonLabel kryptonLabel;
    }
}