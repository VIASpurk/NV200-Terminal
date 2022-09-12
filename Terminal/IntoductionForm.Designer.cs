namespace Terminal
{
    partial class Intoduction 
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.IntoductionDebug = new System.Windows.Forms.Button();
			this.labelPC = new System.Windows.Forms.Label();
			this.timerIntroduction = new System.Windows.Forms.Timer(this.components);
			this.kryptonButtonIntoductionNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryptonButtonIntoductionCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.labelIntroductionText = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelChoiseText = new System.Windows.Forms.Label();
			this.roundedPanel3 = new Terminal.Controls.RoundedPanel();
			this.labelIntroductonPC = new System.Windows.Forms.Label();
			this.IntoductionText = new System.Windows.Forms.Label();
			this.labelCash = new System.Windows.Forms.Label();
			this.roundedPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// IntoductionDebug
			// 
			this.IntoductionDebug.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.IntoductionDebug.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.IntoductionDebug.Location = new System.Drawing.Point(584, 954);
			this.IntoductionDebug.Name = "IntoductionDebug";
			this.IntoductionDebug.Size = new System.Drawing.Size(105, 49);
			this.IntoductionDebug.TabIndex = 4;
			this.IntoductionDebug.Text = "Отладка";
			this.IntoductionDebug.UseVisualStyleBackColor = true;
			this.IntoductionDebug.Click += new System.EventHandler(this.IntoductionDebug_Click);
			// 
			// labelPC
			// 
			this.labelPC.AutoSize = true;
			this.labelPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F);
			this.labelPC.Location = new System.Drawing.Point(231, 45);
			this.labelPC.Name = "labelPC";
			this.labelPC.Size = new System.Drawing.Size(0, 32);
			this.labelPC.TabIndex = 6;
			// 
			// timerIntroduction
			// 
			this.timerIntroduction.Interval = 60000;
			this.timerIntroduction.Tick += new System.EventHandler(this.timerIntroduction_Tick);
			// 
			// kryptonButtonIntoductionNext
			// 
			this.kryptonButtonIntoductionNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.kryptonButtonIntoductionNext.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Italic);
			this.kryptonButtonIntoductionNext.Location = new System.Drawing.Point(970, 938);
			this.kryptonButtonIntoductionNext.Name = "kryptonButtonIntoductionNext";
			this.kryptonButtonIntoductionNext.Size = new System.Drawing.Size(270, 90);
			this.kryptonButtonIntoductionNext.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.kryptonButtonIntoductionNext.StateCommon.Back.Color2 = System.Drawing.Color.White;
			this.kryptonButtonIntoductionNext.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonButtonIntoductionNext.StateCommon.Border.Rounding = 40;
			this.kryptonButtonIntoductionNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.kryptonButtonIntoductionNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.DarkGray;
			this.kryptonButtonIntoductionNext.TabIndex = 33;
			this.kryptonButtonIntoductionNext.Values.Text = "Далее";
			this.kryptonButtonIntoductionNext.Click += new System.EventHandler(this.kryptonButtonIntoductionNext_Click);
			// 
			// kryptonButtonIntoductionCancel
			// 
			this.kryptonButtonIntoductionCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.kryptonButtonIntoductionCancel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Italic);
			this.kryptonButtonIntoductionCancel.Location = new System.Drawing.Point(66, 938);
			this.kryptonButtonIntoductionCancel.Name = "kryptonButtonIntoductionCancel";
			this.kryptonButtonIntoductionCancel.Size = new System.Drawing.Size(270, 90);
			this.kryptonButtonIntoductionCancel.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.kryptonButtonIntoductionCancel.StateCommon.Back.Color2 = System.Drawing.Color.White;
			this.kryptonButtonIntoductionCancel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonButtonIntoductionCancel.StateCommon.Border.Rounding = 40;
			this.kryptonButtonIntoductionCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.kryptonButtonIntoductionCancel.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.DarkGray;
			this.kryptonButtonIntoductionCancel.TabIndex = 34;
			this.kryptonButtonIntoductionCancel.Values.Text = "Отмена";
			this.kryptonButtonIntoductionCancel.Click += new System.EventHandler(this.kryptonButtonIntoductionCancel_Click);
			// 
			// labelIntroductionText
			// 
			this.labelIntroductionText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.labelIntroductionText.AutoSize = true;
			this.labelIntroductionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelIntroductionText.ForeColor = System.Drawing.Color.White;
			this.labelIntroductionText.Location = new System.Drawing.Point(375, 790);
			this.labelIntroductionText.Name = "labelIntroductionText";
			this.labelIntroductionText.Size = new System.Drawing.Size(558, 39);
			this.labelIntroductionText.TabIndex = 37;
			this.labelIntroductionText.Text = "ТЕРМИНАЛ СДАЧИ НЕ ВЫДАЕТ";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(260, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(805, 117);
			this.label1.TabIndex = 43;
			this.label1.Text = "ВСТАВЬТЕ КУПЮРЫ В КУПЮРОПРИЕМНИК. ДОЖДИТЕСЬ ПОКА В ПОЛЕ \"ВНЕСЕННАЯ СУММА\" ПОЯВИТС" +
    "Я СУММА ВНЕСЕННЫХ ВАМИ ДЕНЕГ";
			// 
			// labelChoiseText
			// 
			this.labelChoiseText.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelChoiseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
			this.labelChoiseText.ForeColor = System.Drawing.Color.White;
			this.labelChoiseText.Location = new System.Drawing.Point(481, 9);
			this.labelChoiseText.Name = "labelChoiseText";
			this.labelChoiseText.Size = new System.Drawing.Size(346, 41);
			this.labelChoiseText.TabIndex = 44;
			this.labelChoiseText.Text = "ПОПОЛНЕНИЕ";
			this.labelChoiseText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedPanel3
			// 
			this.roundedPanel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.roundedPanel3.BackColor = System.Drawing.Color.White;
			this.roundedPanel3.Controls.Add(this.labelIntroductonPC);
			this.roundedPanel3.Controls.Add(this.IntoductionText);
			this.roundedPanel3.Controls.Add(this.labelCash);
			this.roundedPanel3.Location = new System.Drawing.Point(205, 376);
			this.roundedPanel3.Name = "roundedPanel3";
			this.roundedPanel3.Size = new System.Drawing.Size(918, 327);
			this.roundedPanel3.TabIndex = 42;
			// 
			// labelIntroductonPC
			// 
			this.labelIntroductonPC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.labelIntroductonPC.AutoSize = true;
			this.labelIntroductonPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelIntroductonPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.labelIntroductonPC.Location = new System.Drawing.Point(241, 57);
			this.labelIntroductonPC.Name = "labelIntroductonPC";
			this.labelIntroductonPC.Size = new System.Drawing.Size(454, 55);
			this.labelIntroductonPC.TabIndex = 36;
			this.labelIntroductonPC.Text = "КОМПЬЮТЕР № 7";
			// 
			// IntoductionText
			// 
			this.IntoductionText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.IntoductionText.AutoSize = true;
			this.IntoductionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
			this.IntoductionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.IntoductionText.Location = new System.Drawing.Point(33, 178);
			this.IntoductionText.Name = "IntoductionText";
			this.IntoductionText.Size = new System.Drawing.Size(518, 55);
			this.IntoductionText.TabIndex = 0;
			this.IntoductionText.Text = "ВНЕСЕННАЯ СУММА";
			// 
			// labelCash
			// 
			this.labelCash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.labelCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelCash.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.labelCash.Location = new System.Drawing.Point(557, 172);
			this.labelCash.Name = "labelCash";
			this.labelCash.Size = new System.Drawing.Size(319, 64);
			this.labelCash.TabIndex = 5;
			this.labelCash.Text = "0";
			this.labelCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Intoduction
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.ClientSize = new System.Drawing.Size(1312, 1069);
			this.Controls.Add(this.labelChoiseText);
			this.Controls.Add(this.labelIntroductionText);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.roundedPanel3);
			this.Controls.Add(this.kryptonButtonIntoductionCancel);
			this.Controls.Add(this.kryptonButtonIntoductionNext);
			this.Controls.Add(this.labelPC);
			this.Controls.Add(this.IntoductionDebug);
			this.Name = "Intoduction";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Intoduction_FormClosing);
			this.Load += new System.EventHandler(this.Intoduction_Load);
			this.Shown += new System.EventHandler(this.Intoduction_Shown);
			this.roundedPanel3.ResumeLayout(false);
			this.roundedPanel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }
        #endregion
        /*private Label IntoductionText;
        private TextBox IntoductionTextBox;
        private Button IntoductionNext;
        private Button IntoductionCancel;
        private Button IntoductionDebug;*/
        private System.Windows.Forms.Label IntoductionText;
        private System.Windows.Forms.Button IntoductionDebug;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.Label labelPC;
        private System.Windows.Forms.Timer timerIntroduction;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonIntoductionNext;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonIntoductionCancel;
        private System.Windows.Forms.Label labelIntroductonPC;
        private System.Windows.Forms.Label labelIntroductionText;
		private Controls.RoundedPanel roundedPanel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelChoiseText;
	}
}

