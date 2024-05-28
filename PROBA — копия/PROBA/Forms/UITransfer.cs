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
    public partial class UITransfer : Form
    {
        UIBank uiBank;
        Depositor currentDepositor;
        BankSG bankSG = BankSG.Instance;

        public UITransfer(UIBank uiBank, Depositor currentDepositor)
        {
            this.uiBank = uiBank;
            this.currentDepositor = currentDepositor;
            InitializeComponent();
            changeDesineTextBox();
            changeDesineButton();
            this.FormClosing += Form_Close;
            this.TSum.KeyPress += Tsum_KeyPress;
            this.TAnotherCard.KeyPress += CheckDigit_KeyPress;
        }

        //Buttons logic
        private void BTransfer_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (TSum.Text != "" && TSum.Text != "0")
            {
                sum = Convert.ToDouble(TSum.Text);
                if(String.IsNullOrEmpty(TAnotherCard.Text) == false)
                {
                    if (bankSG.checkAccount(Convert.ToInt32(TAnotherCard.Text)))
                    {
                        if (Convert.ToInt32(TAnotherCard.Text) != currentDepositor.AccountNumber)
                        {
                            if (sum < currentDepositor.deposit.CDA)
                            {
                                bankSG.getDepositor(Convert.ToInt32(TAnotherCard.Text)).deposit.TopUpCheck(sum);
                                currentDepositor.deposit.WithDrawCheck(sum);
                                currentDepositor.deposit.setTypeOperTran(sum);
                                bankSG.getDepositor(Convert.ToInt32(TAnotherCard.Text)).deposit.setTypeOperTran(sum);
                                MessageBox.Show("Переказ завершився успішно");
                                ReceiptPrinter.AskToPrintReceipt($"Тип операції:{currentDepositor.deposit.typeOperation} \nНомер поточного рахунку: {currentDepositor.AccountNumber} \nСума:{TSum.Text} \nНомер іншого рахунку:{TAnotherCard.Text}\nЗалишок на рахунку: {currentDepositor.deposit.CDA} \nДата: {currentDepositor.deposit.LDO}");
                                uiBank.UpDATE();
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
                            MessageBox.Show("Ви не можете перекинути гроші на свою картку");
                            TAnotherCard.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("В базі немає такого номера картки");
                        TAnotherCard.Text = "";
                    }
                }
                else
                    MessageBox.Show($"Введіть номер картки");
            }
            else
            {
                MessageBox.Show($"Введіть суму");
                TSum.Text = "";
            }
                

            
        }
        private void BStepBack_Click(object sender, EventArgs e)
        {      
            this.Close();
        }

        //Events logic
        private void Form_Close(object sender, EventArgs e)
        {
            uiBank.Show();
        }
        private void CheckDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
