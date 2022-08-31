namespace Terminal
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
            this.kryptonButtonDepositing = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonWithdrawal = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.labelIntroductonPC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kryptonButtonDepositing
            // 
            this.kryptonButtonDepositing.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Italic);
            this.kryptonButtonDepositing.Location = new System.Drawing.Point(367, 145);
            this.kryptonButtonDepositing.Name = "kryptonButtonDepositing";
            this.kryptonButtonDepositing.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonButtonDepositing.OverrideDefault.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.kryptonButtonDepositing.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.kryptonButtonDepositing.OverrideFocus.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButtonDepositing.OverrideFocus.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButtonDepositing.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.kryptonButtonDepositing.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonDepositing.Size = new System.Drawing.Size(608, 182);
            this.kryptonButtonDepositing.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonButtonDepositing.StateCommon.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.kryptonButtonDepositing.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.kryptonButtonDepositing.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.kryptonButtonDepositing.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonButtonDepositing.StateCommon.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.kryptonButtonDepositing.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButtonDepositing.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonDepositing.StateCommon.Border.Rounding = 18;
            this.kryptonButtonDepositing.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.kryptonButtonDepositing.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonButtonDepositing.StateNormal.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.kryptonButtonDepositing.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonDepositing.StateNormal.Border.Rounding = 18;
            this.kryptonButtonDepositing.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.kryptonButtonDepositing.TabIndex = 5;
            this.kryptonButtonDepositing.Values.Text = "Пополнение";
            this.kryptonButtonDepositing.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButtonWithdrawal
            // 
            this.kryptonButtonWithdrawal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonButtonWithdrawal.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Italic);
            this.kryptonButtonWithdrawal.Location = new System.Drawing.Point(367, 497);
            this.kryptonButtonWithdrawal.Name = "kryptonButtonWithdrawal";
            this.kryptonButtonWithdrawal.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonButtonWithdrawal.OverrideDefault.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.kryptonButtonWithdrawal.Size = new System.Drawing.Size(608, 182);
            this.kryptonButtonWithdrawal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonButtonWithdrawal.StateCommon.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.kryptonButtonWithdrawal.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.kryptonButtonWithdrawal.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonButtonWithdrawal.StateCommon.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.kryptonButtonWithdrawal.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButtonWithdrawal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonWithdrawal.StateCommon.Border.Rounding = 18;
            this.kryptonButtonWithdrawal.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.kryptonButtonWithdrawal.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonButtonWithdrawal.StateNormal.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.kryptonButtonWithdrawal.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonButtonWithdrawal.StateNormal.Border.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.kryptonButtonWithdrawal.StateNormal.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.kryptonButtonWithdrawal.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonWithdrawal.StateNormal.Border.Rounding = 18;
            this.kryptonButtonWithdrawal.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonButtonWithdrawal.TabIndex = 6;
            this.kryptonButtonWithdrawal.Values.Text = "Снятие";
            this.kryptonButtonWithdrawal.Click += new System.EventHandler(this.kryptonButtonWithdrawal_Click);
            // 
            // labelIntroductonPC
            // 
            this.labelIntroductonPC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelIntroductonPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIntroductonPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelIntroductonPC.Location = new System.Drawing.Point(263, 9);
            this.labelIntroductonPC.Name = "labelIntroductonPC";
            this.labelIntroductonPC.Size = new System.Drawing.Size(819, 61);
            this.labelIntroductonPC.TabIndex = 37;
            this.labelIntroductonPC.Text = "Добро пожаловать! Рады Вас видеть!";
            this.labelIntroductonPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelIntroductonPC.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1312, 741);
            this.Controls.Add(this.labelIntroductonPC);
            this.Controls.Add(this.kryptonButtonWithdrawal);
            this.Controls.Add(this.kryptonButtonDepositing);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приветствие";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BeginWindow_Load);
            this.Shown += new System.EventHandler(this.BeginWindow_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonDepositing;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonWithdrawal;
        private System.Windows.Forms.Label labelIntroductonPC;
    }
}