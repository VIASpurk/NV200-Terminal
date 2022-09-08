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
			this.components = new System.ComponentModel.Container();
			this.kryptonButtonDepositing = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryptonButtonWithdrawal = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.labelIntroductonPC = new System.Windows.Forms.Label();
			this.PingTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// kryptonButtonDepositing
			// 
			this.kryptonButtonDepositing.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.kryptonButtonDepositing.CausesValidation = false;
			this.kryptonButtonDepositing.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Italic);
			this.kryptonButtonDepositing.Location = new System.Drawing.Point(367, 175);
			this.kryptonButtonDepositing.Name = "kryptonButtonDepositing";
			this.kryptonButtonDepositing.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
			this.kryptonButtonDepositing.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
			this.kryptonButtonDepositing.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
			this.kryptonButtonDepositing.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkGray;
			this.kryptonButtonDepositing.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonButtonDepositing.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
			this.kryptonButtonDepositing.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
			this.kryptonButtonDepositing.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
			this.kryptonButtonDepositing.OverrideFocus.Border.Color1 = System.Drawing.Color.Gray;
			this.kryptonButtonDepositing.OverrideFocus.Border.Color2 = System.Drawing.Color.DarkGray;
			this.kryptonButtonDepositing.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonButtonDepositing.Size = new System.Drawing.Size(608, 182);
			this.kryptonButtonDepositing.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.kryptonButtonDepositing.StateCommon.Back.Color2 = System.Drawing.Color.White;
			this.kryptonButtonDepositing.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.kryptonButtonDepositing.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
			this.kryptonButtonDepositing.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.kryptonButtonDepositing.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
			this.kryptonButtonDepositing.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonButtonDepositing.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryptonButtonDepositing.StateCommon.Border.Rounding = 18;
			this.kryptonButtonDepositing.StateCommon.Border.Width = 1;
			this.kryptonButtonDepositing.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.kryptonButtonDepositing.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
			this.kryptonButtonDepositing.TabIndex = 1;
			this.kryptonButtonDepositing.TabStop = false;
			this.kryptonButtonDepositing.Values.Text = "Пополнение";
			this.kryptonButtonDepositing.Click += new System.EventHandler(this.KryptonButton1_Click);
			// 
			// kryptonButtonWithdrawal
			// 
			this.kryptonButtonWithdrawal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.kryptonButtonWithdrawal.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Italic);
			this.kryptonButtonWithdrawal.Location = new System.Drawing.Point(367, 480);
			this.kryptonButtonWithdrawal.Name = "kryptonButtonWithdrawal";
			this.kryptonButtonWithdrawal.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
			this.kryptonButtonWithdrawal.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
			this.kryptonButtonWithdrawal.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
			this.kryptonButtonWithdrawal.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkGray;
			this.kryptonButtonWithdrawal.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonButtonWithdrawal.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
			this.kryptonButtonWithdrawal.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
			this.kryptonButtonWithdrawal.OverrideFocus.Border.Color1 = System.Drawing.Color.Gray;
			this.kryptonButtonWithdrawal.OverrideFocus.Border.Color2 = System.Drawing.Color.DarkGray;
			this.kryptonButtonWithdrawal.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonButtonWithdrawal.Size = new System.Drawing.Size(608, 182);
			this.kryptonButtonWithdrawal.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.kryptonButtonWithdrawal.StateCommon.Back.Color2 = System.Drawing.Color.White;
			this.kryptonButtonWithdrawal.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
			this.kryptonButtonWithdrawal.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
			this.kryptonButtonWithdrawal.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.kryptonButtonWithdrawal.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
			this.kryptonButtonWithdrawal.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.kryptonButtonWithdrawal.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
			this.kryptonButtonWithdrawal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonButtonWithdrawal.StateCommon.Border.Rounding = 18;
			this.kryptonButtonWithdrawal.StateCommon.Border.Width = 1;
			this.kryptonButtonWithdrawal.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.kryptonButtonWithdrawal.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
			this.kryptonButtonWithdrawal.TabIndex = 2;
			this.kryptonButtonWithdrawal.Values.Text = "Снятие";
			this.kryptonButtonWithdrawal.Click += new System.EventHandler(this.KryptonButtonWithdrawal_Click);
			// 
			// labelIntroductonPC
			// 
			this.labelIntroductonPC.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelIntroductonPC.AutoSize = true;
			this.labelIntroductonPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelIntroductonPC.ForeColor = System.Drawing.Color.White;
			this.labelIntroductonPC.Location = new System.Drawing.Point(474, 17);
			this.labelIntroductonPC.Name = "labelIntroductonPC";
			this.labelIntroductonPC.Size = new System.Drawing.Size(398, 44);
			this.labelIntroductonPC.TabIndex = 0;
			this.labelIntroductonPC.Text = "Выберите операцию";
			this.labelIntroductonPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PingTimer
			// 
			this.PingTimer.Interval = 500;
			this.PingTimer.Tick += new System.EventHandler(this.PingTimer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.ClientSize = new System.Drawing.Size(1312, 741);
			this.Controls.Add(this.labelIntroductonPC);
			this.Controls.Add(this.kryptonButtonWithdrawal);
			this.Controls.Add(this.kryptonButtonDepositing);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Приветствие";
			this.TopMost = true;
			this.Shown += new System.EventHandler(this.BeginWindow_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonDepositing;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonWithdrawal;
        private System.Windows.Forms.Label labelIntroductonPC;
		private System.Windows.Forms.Timer PingTimer;
	}
}