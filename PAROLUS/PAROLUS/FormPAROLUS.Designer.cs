namespace PAROLUS
{
    partial class FormPAROLUS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPAROLUS));
            this.groupBoxGenerationsParams = new System.Windows.Forms.GroupBox();
            this.labelPassLengthValue = new System.Windows.Forms.Label();
            this.labelPassLength = new System.Windows.Forms.Label();
            this.trackBarPasswordLength = new System.Windows.Forms.TrackBar();
            this.checkBoxUseUppercaseLetters = new System.Windows.Forms.CheckBox();
            this.checkBoxUseLowercaseLetters = new System.Windows.Forms.CheckBox();
            this.checkBoxUseDigits = new System.Windows.Forms.CheckBox();
            this.CheckBoxUseSpecialSymbols = new System.Windows.Forms.CheckBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClearPassword = new System.Windows.Forms.Button();
            this.labelGeneratedPassword = new System.Windows.Forms.Label();
            this.labelPasswordCopiedToClipboard = new System.Windows.Forms.Label();
            this.labelWarningMessageTitle = new System.Windows.Forms.Label();
            this.labelWarningMessage = new System.Windows.Forms.Label();
            this.textBoxGeneratedPassword = new System.Windows.Forms.TextBox();
            this.timerShowLabelCopiedToClipboard = new System.Windows.Forms.Timer(this.components);
            this.imageListDefault = new System.Windows.Forms.ImageList(this.components);
            this.toolTipForControl = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxGenerationsParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxGenerationsParams
            // 
            this.groupBoxGenerationsParams.Controls.Add(this.labelPassLengthValue);
            this.groupBoxGenerationsParams.Controls.Add(this.labelPassLength);
            this.groupBoxGenerationsParams.Controls.Add(this.trackBarPasswordLength);
            this.groupBoxGenerationsParams.Controls.Add(this.checkBoxUseUppercaseLetters);
            this.groupBoxGenerationsParams.Controls.Add(this.checkBoxUseLowercaseLetters);
            this.groupBoxGenerationsParams.Controls.Add(this.checkBoxUseDigits);
            this.groupBoxGenerationsParams.Controls.Add(this.CheckBoxUseSpecialSymbols);
            this.groupBoxGenerationsParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGenerationsParams.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGenerationsParams.Name = "groupBoxGenerationsParams";
            this.groupBoxGenerationsParams.Size = new System.Drawing.Size(560, 197);
            this.groupBoxGenerationsParams.TabIndex = 0;
            this.groupBoxGenerationsParams.TabStop = false;
            this.groupBoxGenerationsParams.Text = "Параметры генерации";
            // 
            // labelPassLengthValue
            // 
            this.labelPassLengthValue.AutoSize = true;
            this.labelPassLengthValue.Location = new System.Drawing.Point(97, 144);
            this.labelPassLengthValue.Name = "labelPassLengthValue";
            this.labelPassLengthValue.Size = new System.Drawing.Size(21, 13);
            this.labelPassLengthValue.TabIndex = 6;
            this.labelPassLengthValue.Text = "##";
            this.labelPassLengthValue.Click += new System.EventHandler(this.labelPassLengthValue_Click);
            // 
            // labelPassLength
            // 
            this.labelPassLength.AutoSize = true;
            this.labelPassLength.Location = new System.Drawing.Point(14, 144);
            this.labelPassLength.Name = "labelPassLength";
            this.labelPassLength.Size = new System.Drawing.Size(85, 13);
            this.labelPassLength.TabIndex = 5;
            this.labelPassLength.Text = "Длина пароля: ";
            this.labelPassLength.Click += new System.EventHandler(this.labelPassLength_Click);
            // 
            // trackBarPasswordLength
            // 
            this.trackBarPasswordLength.Location = new System.Drawing.Point(130, 140);
            this.trackBarPasswordLength.Maximum = 30;
            this.trackBarPasswordLength.Minimum = 5;
            this.trackBarPasswordLength.Name = "trackBarPasswordLength";
            this.trackBarPasswordLength.Size = new System.Drawing.Size(313, 45);
            this.trackBarPasswordLength.TabIndex = 4;
            this.trackBarPasswordLength.Value = 5;
            this.trackBarPasswordLength.Scroll += new System.EventHandler(this.trackBarPasswordLength_Scroll);
            // 
            // checkBoxUseUppercaseLetters
            // 
            this.checkBoxUseUppercaseLetters.AutoSize = true;
            this.checkBoxUseUppercaseLetters.Location = new System.Drawing.Point(17, 88);
            this.checkBoxUseUppercaseLetters.Name = "checkBoxUseUppercaseLetters";
            this.checkBoxUseUppercaseLetters.Size = new System.Drawing.Size(192, 17);
            this.checkBoxUseUppercaseLetters.TabIndex = 3;
            this.checkBoxUseUppercaseLetters.Text = "Использовать прописные буквы";
            this.checkBoxUseUppercaseLetters.UseVisualStyleBackColor = true;
            this.checkBoxUseUppercaseLetters.CheckedChanged += new System.EventHandler(this.checkBoxUseUppercaseLetters_CheckedChanged);
            // 
            // checkBoxUseLowercaseLetters
            // 
            this.checkBoxUseLowercaseLetters.AutoSize = true;
            this.checkBoxUseLowercaseLetters.Location = new System.Drawing.Point(17, 65);
            this.checkBoxUseLowercaseLetters.Name = "checkBoxUseLowercaseLetters";
            this.checkBoxUseLowercaseLetters.Size = new System.Drawing.Size(184, 17);
            this.checkBoxUseLowercaseLetters.TabIndex = 2;
            this.checkBoxUseLowercaseLetters.Text = "Использовать строчные буквы";
            this.checkBoxUseLowercaseLetters.UseVisualStyleBackColor = true;
            this.checkBoxUseLowercaseLetters.CheckedChanged += new System.EventHandler(this.checkBoxUseLowercaseLetters_CheckedChanged);
            // 
            // checkBoxUseDigits
            // 
            this.checkBoxUseDigits.AutoSize = true;
            this.checkBoxUseDigits.Location = new System.Drawing.Point(17, 42);
            this.checkBoxUseDigits.Name = "checkBoxUseDigits";
            this.checkBoxUseDigits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxUseDigits.Size = new System.Drawing.Size(136, 17);
            this.checkBoxUseDigits.TabIndex = 1;
            this.checkBoxUseDigits.Text = "Использовать цифры";
            this.checkBoxUseDigits.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxUseDigits.UseVisualStyleBackColor = true;
            this.checkBoxUseDigits.CheckedChanged += new System.EventHandler(this.checkBoxUseDigits_CheckedChanged);
            // 
            // CheckBoxUseSpecialSymbols
            // 
            this.CheckBoxUseSpecialSymbols.AutoSize = true;
            this.CheckBoxUseSpecialSymbols.Location = new System.Drawing.Point(17, 19);
            this.CheckBoxUseSpecialSymbols.Name = "CheckBoxUseSpecialSymbols";
            this.CheckBoxUseSpecialSymbols.Size = new System.Drawing.Size(172, 17);
            this.CheckBoxUseSpecialSymbols.TabIndex = 0;
            this.CheckBoxUseSpecialSymbols.Text = "Использовать спецсимволы";
            this.CheckBoxUseSpecialSymbols.UseVisualStyleBackColor = true;
            this.CheckBoxUseSpecialSymbols.CheckedChanged += new System.EventHandler(this.CheckBoxUseSpecialSymbols_CheckedChanged);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerate.Location = new System.Drawing.Point(12, 215);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(123, 34);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "&Сгенерировать";
            this.toolTipForControl.SetToolTip(this.buttonGenerate, "Сгенерировать надёжный пароль с заданной длинной и используемыми символами");
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(497, 286);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выход";
            this.toolTipForControl.SetToolTip(this.buttonExit, "Выйти из программы");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClearPassword
            // 
            this.buttonClearPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearPassword.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonClearPassword.ImageIndex = 0;
            this.buttonClearPassword.ImageList = this.imageListDefault;
            this.buttonClearPassword.Location = new System.Drawing.Point(537, 216);
            this.buttonClearPassword.Name = "buttonClearPassword";
            this.buttonClearPassword.Size = new System.Drawing.Size(35, 34);
            this.buttonClearPassword.TabIndex = 1;
            this.toolTipForControl.SetToolTip(this.buttonClearPassword, "Очистить поле");
            this.buttonClearPassword.UseVisualStyleBackColor = true;
            this.buttonClearPassword.Click += new System.EventHandler(this.buttonClearPassword_Click);
            // 
            // labelGeneratedPassword
            // 
            this.labelGeneratedPassword.AutoSize = true;
            this.labelGeneratedPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGeneratedPassword.Location = new System.Drawing.Point(170, 227);
            this.labelGeneratedPassword.Name = "labelGeneratedPassword";
            this.labelGeneratedPassword.Size = new System.Drawing.Size(51, 13);
            this.labelGeneratedPassword.TabIndex = 2;
            this.labelGeneratedPassword.Text = "Пароль: ";
            // 
            // labelPasswordCopiedToClipboard
            // 
            this.labelPasswordCopiedToClipboard.AutoSize = true;
            this.labelPasswordCopiedToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordCopiedToClipboard.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelPasswordCopiedToClipboard.Location = new System.Drawing.Point(263, 250);
            this.labelPasswordCopiedToClipboard.Name = "labelPasswordCopiedToClipboard";
            this.labelPasswordCopiedToClipboard.Size = new System.Drawing.Size(192, 13);
            this.labelPasswordCopiedToClipboard.TabIndex = 3;
            this.labelPasswordCopiedToClipboard.Text = "Пароль скопирован в буфер обмена";
            // 
            // labelWarningMessageTitle
            // 
            this.labelWarningMessageTitle.AutoSize = true;
            this.labelWarningMessageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWarningMessageTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.labelWarningMessageTitle.Location = new System.Drawing.Point(26, 261);
            this.labelWarningMessageTitle.Name = "labelWarningMessageTitle";
            this.labelWarningMessageTitle.Size = new System.Drawing.Size(88, 13);
            this.labelWarningMessageTitle.TabIndex = 4;
            this.labelWarningMessageTitle.Text = "Рекомендации: ";
            // 
            // labelWarningMessage
            // 
            this.labelWarningMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWarningMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.labelWarningMessage.Location = new System.Drawing.Point(26, 283);
            this.labelWarningMessage.Name = "labelWarningMessage";
            this.labelWarningMessage.Size = new System.Drawing.Size(369, 35);
            this.labelWarningMessage.TabIndex = 5;
            this.labelWarningMessage.Text = "длина от 8 символов и более, с использованием спецсимволов, цифр, строчных и проп" +
    "исных латинских букв";
            // 
            // textBoxGeneratedPassword
            // 
            this.textBoxGeneratedPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGeneratedPassword.Location = new System.Drawing.Point(227, 224);
            this.textBoxGeneratedPassword.Name = "textBoxGeneratedPassword";
            this.textBoxGeneratedPassword.Size = new System.Drawing.Size(289, 20);
            this.textBoxGeneratedPassword.TabIndex = 6;
            this.textBoxGeneratedPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timerShowLabelCopiedToClipboard
            // 
            this.timerShowLabelCopiedToClipboard.Interval = 2000;
            this.timerShowLabelCopiedToClipboard.Tick += new System.EventHandler(this.timerShowLabelCopiedToClipboard_Tick);
            // 
            // imageListDefault
            // 
            this.imageListDefault.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDefault.ImageStream")));
            this.imageListDefault.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDefault.Images.SetKeyName(0, "2638315_bin_delete_dust_erace_garbage_icon.png");
            // 
            // FormPAROLUS
            // 
            this.AcceptButton = this.buttonGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(586, 319);
            this.Controls.Add(this.textBoxGeneratedPassword);
            this.Controls.Add(this.labelWarningMessage);
            this.Controls.Add(this.labelWarningMessageTitle);
            this.Controls.Add(this.labelPasswordCopiedToClipboard);
            this.Controls.Add(this.labelGeneratedPassword);
            this.Controls.Add(this.buttonClearPassword);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.groupBoxGenerationsParams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPAROLUS";
            this.Text = "PAROLUS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPAROLUS_FormClosing);
            this.Load += new System.EventHandler(this.FormPAROLUS_Load);
            this.groupBoxGenerationsParams.ResumeLayout(false);
            this.groupBoxGenerationsParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGenerationsParams;
        private System.Windows.Forms.CheckBox checkBoxUseUppercaseLetters;
        private System.Windows.Forms.CheckBox checkBoxUseLowercaseLetters;
        private System.Windows.Forms.CheckBox checkBoxUseDigits;
        private System.Windows.Forms.CheckBox CheckBoxUseSpecialSymbols;
        private System.Windows.Forms.TrackBar trackBarPasswordLength;
        private System.Windows.Forms.Label labelPassLength;
        private System.Windows.Forms.Label labelPassLengthValue;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClearPassword;
        private System.Windows.Forms.Label labelGeneratedPassword;
        private System.Windows.Forms.Label labelPasswordCopiedToClipboard;
        private System.Windows.Forms.Label labelWarningMessageTitle;
        private System.Windows.Forms.Label labelWarningMessage;
        private System.Windows.Forms.TextBox textBoxGeneratedPassword;
        private System.Windows.Forms.Timer timerShowLabelCopiedToClipboard;
        private System.Windows.Forms.ImageList imageListDefault;
        private System.Windows.Forms.ToolTip toolTipForControl;
    }
}

