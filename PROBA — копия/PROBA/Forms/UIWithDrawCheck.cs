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
    public partial class UIWithDrawCheck : Form
    {
        UIBank Uibank;
        BankSG bankSG = BankSG.Instance;
        Depositor currentDepositor;
        public UIWithDrawCheck(UIBank Uibank, Depositor currentDepositor)
        {
            this.currentDepositor = currentDepositor;
            this.Uibank = Uibank;
            InitializeComponent();
            this.FormClosing += Form_Close;
            this.TSum.KeyPress += Tsum_KeyPress;
        }

        //Buttons logic
        private void BWithDrawMoney_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TSum.Text) == false)
            {
                double sum = Convert.ToDouble(TSum.Text);
                if (sum < currentDepositor.deposit.CDA)
                {
                    currentDepositor.deposit.WithDrawCheck(sum);
                    MessageBox.Show("Гроші були успішно зняті");
                    ReceiptPrinter.AskToPrintReceipt($"Поточний рахунок {currentDepositor.AccountNumber} \nТип операції:{currentDepositor.deposit.typeOperation} \nСума:{currentDepositor.deposit.lastSumOp.ToString()} \nЗалишок на рахунку: {currentDepositor.deposit.CDA} \nДата здійснення операції: {currentDepositor.deposit.LDO}");
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
                MessageBox.Show("Введіть суму");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Events logic
        private void Form_Close(object sender, EventArgs e)
        {
            Uibank.Show();
        }
        private void Tsum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Только цифры, точку и Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            // Проверяем, что одна точка
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
    }
}
