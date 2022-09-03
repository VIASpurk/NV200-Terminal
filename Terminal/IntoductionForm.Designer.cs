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
			this.roundedPanel3 = new Terminal.Controls.RoundedPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.roundedPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// IntoductionText
			// 
			this.IntoductionText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.IntoductionText.AutoSize = true;
			this.IntoductionText.Font = new System.Drawing.Font("Palatino Linotype", 36F);
			this.IntoductionText.Location = new System.Drawing.Point(80, 179);
			this.IntoductionText.Name = "IntoductionText";
			this.IntoductionText.Size = new System.Drawing.Size(410, 64);
			this.IntoductionText.TabIndex = 0;
			this.IntoductionText.Text = "Внесенная сумма";
			// 
			// IntoductionDebug
			// 
			this.IntoductionDebug.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.IntoductionDebug.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.IntoductionDebug.Location = new System.Drawing.Point(584, 713);
			this.IntoductionDebug.Name = "IntoductionDebug";
			this.IntoductionDebug.Size = new System.Drawing.Size(105, 49);
			this.IntoductionDebug.TabIndex = 4;
			this.IntoductionDebug.Text = "Отладка";
			this.IntoductionDebug.UseVisualStyleBackColor = true;
			this.IntoductionDebug.Click += new System.EventHandler(this.IntoductionDebug_Click);
			// 
			// labelCash
			// 
			this.labelCash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.labelCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelCash.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCash.Location = new System.Drawing.Point(505, 179);
			this.labelCash.Name = "labelCash";
			this.labelCash.Size = new System.Drawing.Size(319, 64);
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
			this.kryptonButtonIntoductionNext.Location = new System.Drawing.Point(970, 697);
			this.kryptonButtonIntoductionNext.Name = "kryptonButtonIntoductionNext";
			this.kryptonButtonIntoductionNext.Size = new System.Drawing.Size(270, 90);
			this.kryptonButtonIntoductionNext.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.kryptonButtonIntoductionNext.StateCommon.Back.Color2 = System.Drawing.Color.White;
			this.kryptonButtonIntoductionNext.StateCommon.Border.Rounding = 40;
			this.kryptonButtonIntoductionNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
			this.kryptonButtonIntoductionCancel.Size = new System.Drawing.Size(270, 90);
			this.kryptonButtonIntoductionCancel.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.kryptonButtonIntoductionCancel.StateCommon.Back.Color2 = System.Drawing.Color.White;
			this.kryptonButtonIntoductionCancel.StateCommon.Border.Rounding = 40;
			this.kryptonButtonIntoductionCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.kryptonButtonIntoductionCancel.TabIndex = 34;
			this.kryptonButtonIntoductionCancel.Values.Text = "Отмена";
			// 
			// labelIntroductonPC
			// 
			this.labelIntroductonPC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.labelIntroductonPC.Font = new System.Drawing.Font("Palatino Linotype", 36F);
			this.labelIntroductonPC.Location = new System.Drawing.Point(253, 44);
			this.labelIntroductonPC.Name = "labelIntroductonPC";
			this.labelIntroductonPC.Size = new System.Drawing.Size(438, 75);
			this.labelIntroductonPC.TabIndex = 36;
			this.labelIntroductonPC.Text = "Компьютер № 7";
			// 
			// labelIntroductionText
			// 
			this.labelIntroductionText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.labelIntroductionText.AutoSize = true;
			this.labelIntroductionText.Font = new System.Drawing.Font("Palatino Linotype", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelIntroductionText.ForeColor = System.Drawing.Color.White;
			this.labelIntroductionText.Location = new System.Drawing.Point(504, 578);
			this.labelIntroductionText.Name = "labelIntroductionText";
			this.labelIntroductionText.Size = new System.Drawing.Size(424, 47);
			this.labelIntroductionText.TabIndex = 37;
			this.labelIntroductionText.Text = "Автомат сдачи не выдает";
			// 
			// labelIntr
			// 
			this.labelIntr.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelIntr.AutoSize = true;
			this.labelIntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelIntr.ForeColor = System.Drawing.Color.White;
			this.labelIntr.Location = new System.Drawing.Point(491, 22);
			this.labelIntr.Name = "labelIntr";
			this.labelIntr.Size = new System.Drawing.Size(389, 55);
			this.labelIntr.TabIndex = 39;
			this.labelIntr.Text = "Внесите деньги";
			// 
			// roundedPanel3
			// 
			this.roundedPanel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.roundedPanel3.BackColor = System.Drawing.Color.White;
			this.roundedPanel3.Controls.Add(this.labelIntroductonPC);
			this.roundedPanel3.Controls.Add(this.IntoductionText);
			this.roundedPanel3.Controls.Add(this.labelCash);
			this.roundedPanel3.Location = new System.Drawing.Point(237, 243);
			this.roundedPanel3.Name = "roundedPanel3";
			this.roundedPanel3.Size = new System.Drawing.Size(918, 297);
			this.roundedPanel3.TabIndex = 42;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(166, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1061, 31);
			this.label1.TabIndex = 43;
			this.label1.Text = "Дождитесь пока в поле \"Внесенная сумма\" появится сумма внесенных вами денег";
			// 
			// Intoduction
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
			this.ClientSize = new System.Drawing.Size(1312, 828);
			this.Controls.Add(this.labelIntroductionText);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelIntr);
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
        private System.Windows.Forms.Label labelIntr;
		private Controls.RoundedPanel roundedPanel3;
		private System.Windows.Forms.Label label1;
	}
}

