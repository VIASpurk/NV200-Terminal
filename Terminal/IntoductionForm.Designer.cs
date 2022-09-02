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
			this.IntoductionText = new System.Windows.Forms.Label();
			this.IntoductionDebug = new System.Windows.Forms.Button();
			this.labelCash = new System.Windows.Forms.Label();
			this.labelPC = new System.Windows.Forms.Label();
			this.timerIntroduction = new System.Windows.Forms.Timer(this.components);
			this.kryptonButtonIntoductionNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryptonButtonIntoductionCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.labelIntroductonPC = new System.Windows.Forms.Label();
			this.labelIntroductionText = new System.Windows.Forms.Label();
			this.labelIntr = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// IntoductionText
			// 
			this.IntoductionText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.IntoductionText.Font = new System.Drawing.Font("Palatino Linotype", 36F);
			this.IntoductionText.Location = new System.Drawing.Point(90, 375);
			this.IntoductionText.Name = "IntoductionText";
			this.IntoductionText.Size = new System.Drawing.Size(470, 91);
			this.IntoductionText.TabIndex = 0;
			this.IntoductionText.Text = "Внесенная сумма";
			// 
			// IntoductionDebug
			// 
			this.IntoductionDebug.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.IntoductionDebug.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.IntoductionDebug.Location = new System.Drawing.Point(556, 697);
			this.IntoductionDebug.Name = "IntoductionDebug";
			this.IntoductionDebug.Size = new System.Drawing.Size(176, 74);
			this.IntoductionDebug.TabIndex = 4;
			this.IntoductionDebug.Text = "Отладка";
			this.IntoductionDebug.UseVisualStyleBackColor = true;
			this.IntoductionDebug.Click += new System.EventHandler(this.IntoductionDebug_Click);
			// 
			// labelCash
			// 
			this.labelCash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.labelCash.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCash.Location = new System.Drawing.Point(515, 356);
			this.labelCash.Name = "labelCash";
			this.labelCash.Size = new System.Drawing.Size(319, 107);
			this.labelCash.TabIndex = 5;
			this.labelCash.Text = "0";
			this.labelCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.kryptonButtonIntoductionNext.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.kryptonButtonIntoductionNext.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Italic);
			this.kryptonButtonIntoductionNext.Location = new System.Drawing.Point(1011, 697);
			this.kryptonButtonIntoductionNext.Name = "kryptonButtonIntoductionNext";
			this.kryptonButtonIntoductionNext.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.kryptonButtonIntoductionNext.OverrideDefault.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
			this.kryptonButtonIntoductionNext.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 18.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.kryptonButtonIntoductionNext.Size = new System.Drawing.Size(233, 74);
			this.kryptonButtonIntoductionNext.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
			this.kryptonButtonIntoductionNext.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.kryptonButtonIntoductionNext.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.kryptonButtonIntoductionNext.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
			this.kryptonButtonIntoductionNext.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonButtonIntoductionNext.StateCommon.Border.Rounding = 18;
			this.kryptonButtonIntoductionNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.kryptonButtonIntoductionNext.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryptonButtonIntoductionNext.StateNormal.Back.Color2 = System.Drawing.Color.DarkCyan;
			this.kryptonButtonIntoductionNext.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonButtonIntoductionNext.StateNormal.Border.Rounding = 10;
			this.kryptonButtonIntoductionNext.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 18.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.kryptonButtonIntoductionNext.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryptonButtonIntoductionNext.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.kryptonButtonIntoductionNext.TabIndex = 33;
			this.kryptonButtonIntoductionNext.Values.Text = "Далее";
			// 
			// kryptonButtonIntoductionCancel
			// 
			this.kryptonButtonIntoductionCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.kryptonButtonIntoductionCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.kryptonButtonIntoductionCancel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Italic);
			this.kryptonButtonIntoductionCancel.Location = new System.Drawing.Point(66, 697);
			this.kryptonButtonIntoductionCancel.Name = "kryptonButtonIntoductionCancel";
			this.kryptonButtonIntoductionCancel.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.kryptonButtonIntoductionCancel.OverrideDefault.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
			this.kryptonButtonIntoductionCancel.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 18.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.kryptonButtonIntoductionCancel.Size = new System.Drawing.Size(233, 74);
			this.kryptonButtonIntoductionCancel.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
			this.kryptonButtonIntoductionCancel.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.kryptonButtonIntoductionCancel.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.kryptonButtonIntoductionCancel.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
			this.kryptonButtonIntoductionCancel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonButtonIntoductionCancel.StateCommon.Border.Rounding = 18;
			this.kryptonButtonIntoductionCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 18.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.kryptonButtonIntoductionCancel.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryptonButtonIntoductionCancel.StateNormal.Back.Color2 = System.Drawing.Color.DarkCyan;
			this.kryptonButtonIntoductionCancel.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonButtonIntoductionCancel.StateNormal.Border.Rounding = 10;
			this.kryptonButtonIntoductionCancel.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 18.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.kryptonButtonIntoductionCancel.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryptonButtonIntoductionCancel.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.kryptonButtonIntoductionCancel.TabIndex = 34;
			this.kryptonButtonIntoductionCancel.Values.Text = "Отмена";
			// 
			// labelIntroductonPC
			// 
			this.labelIntroductonPC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.labelIntroductonPC.Font = new System.Drawing.Font("Palatino Linotype", 36F);
			this.labelIntroductonPC.Location = new System.Drawing.Point(377, 281);
			this.labelIntroductonPC.Name = "labelIntroductonPC";
			this.labelIntroductonPC.Size = new System.Drawing.Size(559, 75);
			this.labelIntroductonPC.TabIndex = 36;
			this.labelIntroductonPC.Text = "Компьютер № 7";
			// 
			// labelIntroductionText
			// 
			this.labelIntroductionText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.labelIntroductionText.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelIntroductionText.Location = new System.Drawing.Point(291, 496);
			this.labelIntroductionText.Name = "labelIntroductionText";
			this.labelIntroductionText.Size = new System.Drawing.Size(680, 81);
			this.labelIntroductionText.TabIndex = 37;
			this.labelIntroductionText.Text = "Автомат сдачи не выдает";
			// 
			// labelIntr
			// 
			this.labelIntr.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelIntr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelIntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelIntr.Location = new System.Drawing.Point(214, 9);
			this.labelIntr.Name = "labelIntr";
			this.labelIntr.Size = new System.Drawing.Size(866, 251);
			this.labelIntr.TabIndex = 39;
			this.labelIntr.Text = "Вставьте купюры в купюроприемник. Дождитесь пока в поле \"Внесенная сумма\" появитс" +
    "я сумма внесенных вами денег";
			// 
			// Intoduction
			// 
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.ClientSize = new System.Drawing.Size(1312, 828);
			this.Controls.Add(this.labelIntr);
			this.Controls.Add(this.labelIntroductonPC);
			this.Controls.Add(this.labelIntroductionText);
			this.Controls.Add(this.kryptonButtonIntoductionCancel);
			this.Controls.Add(this.kryptonButtonIntoductionNext);
			this.Controls.Add(this.labelPC);
			this.Controls.Add(this.labelCash);
			this.Controls.Add(this.IntoductionDebug);
			this.Controls.Add(this.IntoductionText);
			this.Name = "Intoduction";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Intoduction_FormClosing);
			this.Load += new System.EventHandler(this.Intoduction_Load);
			this.Shown += new System.EventHandler(this.Intoduction_Shown);
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
        private System.Windows.Forms.Label labelIntr;
    }
}

