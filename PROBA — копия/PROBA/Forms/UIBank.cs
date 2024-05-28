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
    public partial class UIBank : Form
    {
        BankSG bankSG = BankSG.Instance;
        Form1 form1;    
        Depositor currentDepositor;
        bool BCloose = false;
        public UIBank(Depositor currentDepositor, Form1 form1)
        {
            this.currentDepositor = currentDepositor; 
            this.form1 = form1;
            InitializeComponent();
            changeDesignButton();
            changeDesignPanel();
            this.FormClosing += UIBank_FormClosing;
        }

        //Buttons logic
        private void TopUpCheck_Click(object sender, EventArgs e)
        {
            UITopUpCheck uITopUpCheck = new UITopUpCheck(this, currentDepositor);
            uITopUpCheck.Show();
            this.Hide();
        }
        private void BAllInfo_Click(object sender, EventArgs e)
        {
            AllInformation allInformation = new AllInformation(this, currentDepositor);
            allInformation.Show();
            this.Hide();
        }
        private void BLogOut_Click(object sender, EventArgs e)
        {
            BCloose = true;
            form1.Show();
            this.Close();
        }
        private void BWithdrawMoney_Click(object sender, EventArgs e)
        {
            UITransfer uITransfer = new UITransfer(this, currentDepositor);
            uITransfer.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UIWithDrawCheck uIWithDrawCheck = new UIWithDrawCheck(this, currentDepositor);
            uIWithDrawCheck.Show();
            this.Hide();
        }
        private void BInvestment_Click(object sender, EventArgs e)
        {
            if (currentDepositor.interestBearingDeposit.IsThereDeposit)
            {
                UIIntersetBearningDeposit uIIntersetBearningDeposit = new UIIntersetBearningDeposit(this, currentDepositor);
                uIIntersetBearningDeposit.Show();
                this.Hide();
            }
            else
            {
                UICreateIntersetBearningDeposit uICreateIntersetBearningDeposit = new UICreateIntersetBearningDeposit(this, currentDepositor);
                uICreateIntersetBearningDeposit.Show();
                this.Hide();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            changeData UIchangeData = new changeData(this, currentDepositor);
            UIchangeData.Show();
            this.Hide();
        }

        //Events logic
        private void UIBank_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(BCloose == true)
            {
                JsonHandler.SaveData(bankSG.getAllClient());
            }
            else
            {
                JsonHandler.SaveData(bankSG.getAllClient());
                Application.Exit();
            }
        }
        private void UIBank_Load(object sender, EventArgs e)
        {

            Money.Text = Math.Round(currentDepositor.deposit.CDA,2).ToString() + " UAH";
            LFIO.Text = currentDepositor.passport.FIO;
            LAccNumber.Text = StaticMethod.AddSpaces(currentDepositor.AccountNumber.ToString());
            LLasOp.Text = $"{currentDepositor.deposit.typeOperation} {currentDepositor.deposit.LDO.ToString("yyyy-MM-dd")} сума:{currentDepositor.deposit.lastSumOp.ToString()}";
            currentDepositor.interestBearingDeposit.UpDateFarmMoney(currentDepositor, this);
            currentDepositor.passport.checkDateOfPassport();
            AdjustFontSize(LFIO);
            AdjustFontSize(LLasOp);
        }

        //Another function
        public void UpDATE()
        {
            Money.Text = Math.Round(currentDepositor.deposit.CDA, 2).ToString() + " UAH";
            LFIO.Text = currentDepositor.passport.FIO;
            LLasOp.Text = $"{currentDepositor.deposit.typeOperation} {currentDepositor.deposit.LDO.ToString("yyyy-MM-dd")} сума:{currentDepositor.deposit.lastSumOp.ToString()}";
            AdjustFontSize(LFIO);
            AdjustFontSize(LLasOp);
        }
        private void AdjustFontSize(Label label)
        {
            label.AutoSize = true; 
            int maxFontSize = 72; 
            int minFontSize = 6; 

            while (label.Size.Width > this.ClientSize.Width - 250 || label.Size.Height > this.ClientSize.Height)
            {
                // Проверяем, не превышает ли текущий размер шрифта максимальное значение
                if (label.Font.Size <= minFontSize)
                    break;

                // Уменьшаем размер шрифта
                label.Font = new Font(label.Font.FontFamily, label.Font.Size - 1, label.Font.Style);
            }
        }

        private void LLasOp_Click(object sender, EventArgs e)
        {
            ReceiptPrinter.AskToPrintReceipt($"Поточний рахунок {currentDepositor.AccountNumber} \nТип операції:{currentDepositor.deposit.typeOperation} \nСума:{currentDepositor.deposit.lastSumOp.ToString()} \nЗалишок на рахунку: {currentDepositor.deposit.CDA} \nДата здійснення операції: {currentDepositor.deposit.LDO}");
        }
    }
}
