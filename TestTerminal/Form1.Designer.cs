namespace TestTerminal
{
	partial class Form1
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
			this.ComPortComboBox = new System.Windows.Forms.ComboBox();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.buttonEnableValidator = new System.Windows.Forms.Button();
			this.buttonEnablePayout = new System.Windows.Forms.Button();
			this.buttonCanPayout = new System.Windows.Forms.Button();
			this.PollTextBox = new System.Windows.Forms.TextBox();
			this.buttonDisableValidator = new System.Windows.Forms.Button();
			this.buttonDisablePayout = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.buttonPayout = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.ActionTextBox = new System.Windows.Forms.TextBox();
			this.buttonGetInfo = new System.Windows.Forms.Button();
			this.ToCashboxcheckBox = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.SaveLogButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// ComPortComboBox
			// 
			this.ComPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComPortComboBox.FormattingEnabled = true;
			this.ComPortComboBox.Location = new System.Drawing.Point(23, 12);
			this.ComPortComboBox.Name = "ComPortComboBox";
			this.ComPortComboBox.Size = new System.Drawing.Size(121, 21);
			this.ComPortComboBox.TabIndex = 0;
			// 
			// buttonConnect
			// 
			this.buttonConnect.Location = new System.Drawing.Point(150, 12);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(84, 23);
			this.buttonConnect.TabIndex = 1;
			this.buttonConnect.Text = "Подключить";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// buttonEnableValidator
			// 
			this.buttonEnableValidator.Location = new System.Drawing.Point(23, 53);
			this.buttonEnableValidator.Name = "buttonEnableValidator";
			this.buttonEnableValidator.Size = new System.Drawing.Size(108, 23);
			this.buttonEnableValidator.TabIndex = 2;
			this.buttonEnableValidator.Text = "EnableValidator";
			this.buttonEnableValidator.UseVisualStyleBackColor = true;
			this.buttonEnableValidator.Click += new System.EventHandler(this.buttonEnableValidator_Click);
			// 
			// buttonEnablePayout
			// 
			this.buttonEnablePayout.Location = new System.Drawing.Point(23, 82);
			this.buttonEnablePayout.Name = "buttonEnablePayout";
			this.buttonEnablePayout.Size = new System.Drawing.Size(108, 23);
			this.buttonEnablePayout.TabIndex = 3;
			this.buttonEnablePayout.Text = "EnablePayout";
			this.buttonEnablePayout.UseVisualStyleBackColor = true;
			this.buttonEnablePayout.Click += new System.EventHandler(this.buttonEnablePayout_Click);
			// 
			// buttonCanPayout
			// 
			this.buttonCanPayout.Location = new System.Drawing.Point(138, 142);
			this.buttonCanPayout.Name = "buttonCanPayout";
			this.buttonCanPayout.Size = new System.Drawing.Size(75, 23);
			this.buttonCanPayout.TabIndex = 4;
			this.buttonCanPayout.Text = "CanPayout";
			this.buttonCanPayout.UseVisualStyleBackColor = true;
			this.buttonCanPayout.Click += new System.EventHandler(this.buttonCanPayout_Click);
			// 
			// PollTextBox
			// 
			this.PollTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PollTextBox.Location = new System.Drawing.Point(354, 31);
			this.PollTextBox.Multiline = true;
			this.PollTextBox.Name = "PollTextBox";
			this.PollTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.PollTextBox.Size = new System.Drawing.Size(306, 389);
			this.PollTextBox.TabIndex = 5;
			// 
			// buttonDisableValidator
			// 
			this.buttonDisableValidator.Location = new System.Drawing.Point(137, 53);
			this.buttonDisableValidator.Name = "buttonDisableValidator";
			this.buttonDisableValidator.Size = new System.Drawing.Size(108, 23);
			this.buttonDisableValidator.TabIndex = 7;
			this.buttonDisableValidator.Text = "DisableValidator";
			this.buttonDisableValidator.UseVisualStyleBackColor = true;
			this.buttonDisableValidator.Click += new System.EventHandler(this.buttonDisableValidator_Click);
			// 
			// buttonDisablePayout
			// 
			this.buttonDisablePayout.Location = new System.Drawing.Point(137, 82);
			this.buttonDisablePayout.Name = "buttonDisablePayout";
			this.buttonDisablePayout.Size = new System.Drawing.Size(108, 23);
			this.buttonDisablePayout.TabIndex = 8;
			this.buttonDisablePayout.Text = "DisablePayout";
			this.buttonDisablePayout.UseVisualStyleBackColor = true;
			this.buttonDisablePayout.Click += new System.EventHandler(this.buttonDisablePayout_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(23, 145);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(109, 20);
			this.numericUpDown1.TabIndex = 9;
			// 
			// buttonPayout
			// 
			this.buttonPayout.Location = new System.Drawing.Point(219, 142);
			this.buttonPayout.Name = "buttonPayout";
			this.buttonPayout.Size = new System.Drawing.Size(75, 23);
			this.buttonPayout.TabIndex = 10;
			this.buttonPayout.Text = "Payout";
			this.buttonPayout.UseVisualStyleBackColor = true;
			this.buttonPayout.Click += new System.EventHandler(this.buttonPayout_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(351, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "PollLog";
			// 
			// ActionTextBox
			// 
			this.ActionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.ActionTextBox.Location = new System.Drawing.Point(23, 171);
			this.ActionTextBox.Multiline = true;
			this.ActionTextBox.Name = "ActionTextBox";
			this.ActionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.ActionTextBox.Size = new System.Drawing.Size(313, 205);
			this.ActionTextBox.TabIndex = 12;
			// 
			// buttonGetInfo
			// 
			this.buttonGetInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonGetInfo.Location = new System.Drawing.Point(23, 382);
			this.buttonGetInfo.Name = "buttonGetInfo";
			this.buttonGetInfo.Size = new System.Drawing.Size(75, 23);
			this.buttonGetInfo.TabIndex = 13;
			this.buttonGetInfo.Text = "GetInfo";
			this.buttonGetInfo.UseVisualStyleBackColor = true;
			this.buttonGetInfo.Click += new System.EventHandler(this.buttonGetInfo_Click);
			// 
			// ToCashboxcheckBox
			// 
			this.ToCashboxcheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ToCashboxcheckBox.AutoSize = true;
			this.ToCashboxcheckBox.Location = new System.Drawing.Point(104, 386);
			this.ToCashboxcheckBox.Name = "ToCashboxcheckBox";
			this.ToCashboxcheckBox.Size = new System.Drawing.Size(106, 17);
			this.ToCashboxcheckBox.TabIndex = 14;
			this.ToCashboxcheckBox.Text = "Store to cashbox";
			this.ToCashboxcheckBox.UseVisualStyleBackColor = true;
			this.ToCashboxcheckBox.CheckedChanged += new System.EventHandler(this.ToCashboxcheckBox_CheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(23, 408);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(96, 17);
			this.checkBox1.TabIndex = 15;
			this.checkBox1.Text = "Hold in escrow";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// SaveLogButton
			// 
			this.SaveLogButton.Location = new System.Drawing.Point(261, 397);
			this.SaveLogButton.Name = "SaveLogButton";
			this.SaveLogButton.Size = new System.Drawing.Size(75, 23);
			this.SaveLogButton.TabIndex = 16;
			this.SaveLogButton.Text = "SaveLog";
			this.SaveLogButton.UseVisualStyleBackColor = true;
			this.SaveLogButton.Click += new System.EventHandler(this.SaveLogButton_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(261, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 17;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(672, 437);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.SaveLogButton);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.ToCashboxcheckBox);
			this.Controls.Add(this.buttonGetInfo);
			this.Controls.Add(this.ActionTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonPayout);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.buttonDisablePayout);
			this.Controls.Add(this.buttonDisableValidator);
			this.Controls.Add(this.PollTextBox);
			this.Controls.Add(this.buttonCanPayout);
			this.Controls.Add(this.buttonEnablePayout);
			this.Controls.Add(this.buttonEnableValidator);
			this.Controls.Add(this.buttonConnect);
			this.Controls.Add(this.ComPortComboBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox ComPortComboBox;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.Button buttonEnableValidator;
		private System.Windows.Forms.Button buttonEnablePayout;
		private System.Windows.Forms.Button buttonCanPayout;
		private System.Windows.Forms.TextBox PollTextBox;
		private System.Windows.Forms.Button buttonDisableValidator;
		private System.Windows.Forms.Button buttonDisablePayout;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button buttonPayout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ActionTextBox;
		private System.Windows.Forms.Button buttonGetInfo;
		private System.Windows.Forms.CheckBox ToCashboxcheckBox;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button SaveLogButton;
		private System.Windows.Forms.Button button1;
	}
}

