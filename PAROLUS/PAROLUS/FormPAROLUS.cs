using System;
using System.Text;
using System.Windows.Forms;
using PAROLUS.Properties;

namespace PAROLUS
{
    public partial class FormPAROLUS : Form
    {
        public string[] digits = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public string[] lowercaseLetters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        public string[] uppercaseLetters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public string[] specialSymbols = new string[]  {"#", "!", "$", ";", "_", "&", "^", "%", "&", "*", "(", ")", "{", "}", "[", "]"};

        public const int USE_DIGITS = 1;
        public const int USE_LOWERCASELETTERS = 2;
        public const int USE_UPPERCASELETTERS = 3;
        public const int USE_SPECIALSYMBOLS = 4;
        
      

        public FormPAROLUS()
        {
            InitializeComponent();
        }

        //Этот метод проверяет кач-во пароля и выводит предупреждающее сообщение, если пароль слабый (т.е. не отмечены все чекбоксы и длина меньше 7 символов)
        public void CheckPasswordStrength() 
        {
            bool isLengthMoreThen7Symbols = trackBarPasswordLength.Value >= 8;
            bool isAllSymbolsUsed = checkBoxUseDigits.Checked && checkBoxUseLowercaseLetters.Checked && checkBoxUseUppercaseLetters.Checked && CheckBoxUseSpecialSymbols.Checked;
            bool isPasswordStrong = isAllSymbolsUsed && isLengthMoreThen7Symbols;
            labelWarningMessageTitle.Visible = !isPasswordStrong;
            labelWarningMessage.Visible = !isPasswordStrong;
        }

        //Этот метод активирует кнопку генерации пароля при условии, что хотя бы 1 чекбокс отмечет (также тут вызывается предыдущий метод для проверки кач-ва пароля)
        public void EnableDisableGenerateButton()
        {
            buttonGenerate.Enabled = checkBoxUseDigits.Checked || checkBoxUseLowercaseLetters.Checked || checkBoxUseUppercaseLetters.Checked || CheckBoxUseSpecialSymbols.Checked;
            CheckPasswordStrength();
        }
        //Следующий блок из 4-х методов обеспечивает собственно активацию кнопки при флажке в любом из чекбоксов
        private void CheckBoxUseSpecialSymbols_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGenerateButton();
        }
        private void checkBoxUseDigits_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGenerateButton();
        }
        private void checkBoxUseLowercaseLetters_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGenerateButton();
        }

        private void checkBoxUseUppercaseLetters_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGenerateButton();
        }

        //Этот метод отвечает за генерацию пароля

        private string GetGeneratedPassword(int passwordLength)
        { 
            StringBuilder sbPassword = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < passwordLength; i++) 
            {
                int randomArrayNumber;
                do
                {
                    randomArrayNumber = random.Next(1, 5);
                }
                while (IsNeedToSkip(randomArrayNumber));

                switch (randomArrayNumber)
                { 
                    case USE_DIGITS:
                        int randomDigitIndex = random.Next(0, digits.Length);
                        sbPassword.Append(digits[randomDigitIndex]);
                        break;
                    case USE_LOWERCASELETTERS:
                        int randomLowerCaseLettersIndex = random.Next(0, lowercaseLetters.Length);
                        sbPassword.Append(lowercaseLetters[randomLowerCaseLettersIndex]);
                        break;
                    case USE_UPPERCASELETTERS:
                        int randomUpperCaseLettersIndex = random.Next(0, uppercaseLetters.Length);
                        sbPassword.Append(uppercaseLetters[randomUpperCaseLettersIndex]);
                        break;
                    case USE_SPECIALSYMBOLS:
                        int randomSpecialSymbolsIndex = random.Next(0, specialSymbols.Length);
                        sbPassword.Append(specialSymbols[randomSpecialSymbolsIndex]);
                        break;
                }
            }
            return sbPassword.ToString();
        }

        private bool IsNeedToSkip(int arrayNumber)
        {
            if (arrayNumber == USE_LOWERCASELETTERS && !checkBoxUseLowercaseLetters.Checked)
            {
                return true;
            }
            else if (arrayNumber == USE_DIGITS && !checkBoxUseDigits.Checked)
            {
                return true;
            }
            else if (arrayNumber == USE_UPPERCASELETTERS && !checkBoxUseUppercaseLetters.Checked)
            {
                return true;
            }
            else if (arrayNumber == USE_SPECIALSYMBOLS && !CheckBoxUseSpecialSymbols.Checked)
            {
                return true;
            }
            return false;

        }

        //Этот обработчик очищает поле
        private void buttonClearPassword_Click(object sender, EventArgs e)
        {
            textBoxGeneratedPassword.Text =  "";
        }

        //Этот обеспечивает эффект пропадания надписи про пароль в буфере обмена
        private void timerShowLabelCopiedToClipboard_Tick(object sender, EventArgs e)
        {
            labelPasswordCopiedToClipboard.Hide();
            timerShowLabelCopiedToClipboard.Stop();
        }

        //Это обработчик главной кнопки генерации пароля
        private void button1_Click(object sender, EventArgs e)
        {
            labelPasswordCopiedToClipboard.Hide();
            timerShowLabelCopiedToClipboard.Stop();
            

            int passwordLength = trackBarPasswordLength.Value;
            textBoxGeneratedPassword.Text = GetGeneratedPassword(passwordLength);
            Clipboard.SetText(textBoxGeneratedPassword.Text);

            labelPasswordCopiedToClipboard.Show();
            timerShowLabelCopiedToClipboard.Start();
        }

      //Загружает дефолтные настройки, обновляет элементы формы
        private void LoadSettings()
        {
            checkBoxUseDigits.Checked = Settings.Default.IsUseDigits;
            checkBoxUseLowercaseLetters.Checked = Settings.Default.IsUseLowercaseLetters;
            checkBoxUseUppercaseLetters.Checked = Settings.Default.IsUseUppercaseLetters;
            CheckBoxUseSpecialSymbols.Checked = Settings.Default.IsUseSpecialSymbols;
            trackBarPasswordLength.Value = Settings.Default.PasswordLength;
            UpdatePasswordLengthValue();
        }

        //Метод обновляет значение метки длины пароля в соответствии с положением трекбара
        private void UpdatePasswordLengthValue()
        {
            labelPassLengthValue.Text = trackBarPasswordLength.Value.ToString();
        }

        //Сохранение настроек программы
        private void SaveSettings () 
        { 
            Settings.Default.IsUseDigits = checkBoxUseDigits.Checked;
            Settings.Default.IsUseLowercaseLetters = checkBoxUseLowercaseLetters.Checked;
            Settings.Default.IsUseUppercaseLetters = checkBoxUseUppercaseLetters.Checked;
            Settings.Default.IsUseSpecialSymbols = CheckBoxUseSpecialSymbols.Checked;
            Settings.Default.PasswordLength = trackBarPasswordLength.Value;
            Settings.Default.Save();
        }

        private void FormPAROLUS_Load(object sender, EventArgs e)
        {
            LoadSettings();
            EnableDisableGenerateButton();
            CheckPasswordStrength();
        }

        private void SaveAndExit()
        { 
            SaveSettings();
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            SaveAndExit();
        }

        private void FormPAROLUS_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAndExit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buttonClearPassword.Enabled = textBoxGeneratedPassword.TextLength > 0;
        }

        private void trackBarPasswordLength_Scroll(object sender, EventArgs e)
        {
            UpdatePasswordLengthValue();
        }














        private void labelPassLength_Click(object sender, EventArgs e)
        {

        }

     

    

       

        private void labelPassLengthValue_Click(object sender, EventArgs e)
        {

        }

      
    }
}
