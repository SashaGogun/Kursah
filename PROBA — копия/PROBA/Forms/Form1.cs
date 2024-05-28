using PROBA.Class;
using PROBA.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PROBA
{
    public partial class Form1 : Form
    {
        BankSG bankSG = BankSG.Instance;
        public Form1()
        {
            InitializeComponent();
            changeDesineTextBox();
            changeDesineButton();
            this.login.KeyPress += login_KeyPress;
        }

        //Button logic
        private void button1_Click(object sender, EventArgs e)
        {
            if(StaticMethod.IsStringConsistsOfNineDigits(login.Text))
            {
                if(bankSG.checkAccount(Convert.ToInt32(login.Text), password.Text))
                {
                    UIBank uIBank = new UIBank(bankSG.getDepositor(Convert.ToInt32(login.Text)), this);
                    uIBank.Show();
                    clearPasAndLog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Такого облікового запису немає. Перевірте логін та пароль.");
                    login.Text = "";
                    password.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ви ввели не правильний формат логіну.");
                login.Text = "";
            }
        }
        private void BAuthorization_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization(this);
            authorization.Show();
            clearPasAndLog();
            this.Hide();
        }

        //TextBox logic
        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Пароль")
            {
                password.Text = "";
                password.TextAlign = HorizontalAlignment.Left;
            }
        }
        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Пароль";
                password.TextAlign = HorizontalAlignment.Center;
            }
        } 
        private void login_Enter(object sender, EventArgs e)
        {
            if (login.Text == "Номер аккаунта")
            {
                login.Text = "";
                login.TextAlign = HorizontalAlignment.Left;
            }
        }
        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                login.Text = "Номер аккаунта";
                login.TextAlign = HorizontalAlignment.Center;
            }
        }
        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой или разрешенным символом (например, Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Если введенный символ не цифра и не Backspace, отменяем событие KeyPress
                e.Handled = true;
            }
        }
        private void clearPasAndLog()
        {
            password.Text = "Пароль";
            login.Text = "Номер аккаунта";
            password.TextAlign = HorizontalAlignment.Center;
            login.TextAlign = HorizontalAlignment.Center;
        }
    }
}