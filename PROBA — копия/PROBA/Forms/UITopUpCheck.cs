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
    public partial class UITopUpCheck : Form
    {
        UIBank Uibank;
        BankSG bankSG = BankSG.Instance;
        Depositor currentDepositor;
        public UITopUpCheck(UIBank Uibank, Depositor currentDepositor)
        {
            this.currentDepositor = currentDepositor;
            this.Uibank = Uibank;
            InitializeComponent();
            this.TSum.KeyPress += Tsum_KeyPress;
            this.FormClosing += Form_Close;
        }

        //Buttons logic
        private void button1_Click(object sender, EventArgs e)
        {
            if (TSum.Text != "" && TSum.Text != "0")
            {
                currentDepositor.deposit.TopUpCheck(double.Parse(TSum.Text));
                Uibank.UpDATE();
                MessageBox.Show("Поповнення рахунку пройшло успішно");
                ReceiptPrinter.AskToPrintReceipt($"Поточний рахунок {currentDepositor.AccountNumber} \nТип операції:{currentDepositor.deposit.typeOperation} \nСума:{currentDepositor.deposit.lastSumOp.ToString()} \nЗалишок на рахунку: {currentDepositor.deposit.CDA} \nДата здійснення операції: {currentDepositor.deposit.LDO}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Введіть сумму");
                TSum.Text = "";
            }
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
