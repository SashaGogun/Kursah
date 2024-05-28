using PROBA.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROBA.Forms
{
    public partial class UICreateIntersetBearningDeposit : Form
    {
        UIBank Uibank;
        BankSG bankSG = BankSG.Instance;
        Depositor currentDepositor;
        public UICreateIntersetBearningDeposit(UIBank Uibank, Depositor currentDepositor)
        {
            this.currentDepositor = currentDepositor;
            this.Uibank = Uibank;
            InitializeComponent();
            this.FormClosing += Form_Close;
            this.TSum.KeyPress += Event_KeyPress;
        }

        //Buttons logic
        private void BPutOnPercent_Click(object sender, EventArgs e)
        {
            double percent = 0;
            int termin = 0;
            double sum = 0;

            if (this.R3Month.Checked)
                termin = 3;
            else if(this.R6Month.Checked)
                termin = 6;
            else if(this.R12Month.Checked)
                termin = 12;
            else
            {
                MessageBox.Show("Ви не вибрали термін.");
                return;
            }

            if (this.R6Percent.Checked)
                percent = 0.06;
            else if (this.R9Percent.Checked)
                percent = 0.09;
            else if (this.R12Percent.Checked)
                percent = 0.12;
            else
            {
                MessageBox.Show("Ви не вибрали відсоток.");
                return;
            }

            if (String.IsNullOrEmpty(TSum.Text) == false)
            {
                sum = Convert.ToDouble(TSum.Text);
                if (sum < currentDepositor.deposit.CDA)
                {
                    currentDepositor.upDateInterestBearingDeposit(new InterestBearingDeposit(true, sum, percent, DateTime.Now.AddMonths(termin)));
                    currentDepositor.deposit.CDA -= sum;
                    MessageBox.Show($"Операція пройшла успішно.");

                    Uibank.UpDATE();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"На вашому рахунку недостатньо коштів.\n Поточний баланс вашого рахунку {currentDepositor.deposit.CDA}");
                    TSum.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ви не ввели суму.");
            }
        }
        private void BStepBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Events logic
        private void Form_Close(object sender, EventArgs e)
        {
            Uibank.Show();
        }
        private void Event_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой или разрешенным символом (например, Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Если введенный символ не цифра и не Backspace, отменяем событие KeyPress
                e.Handled = true;
            }
        }

    }
}
