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
    public partial class UIIntersetBearningDeposit : Form
    {
        BankSG bankSG = BankSG.Instance;
        UIBank iBank;
        Depositor currentDepositor;
        public UIIntersetBearningDeposit(UIBank iBank, Depositor currentDepositor)
        {
            InitializeComponent();
            this.iBank = iBank;
            this.currentDepositor = currentDepositor;
            this.FormClosing += Form_Close;
        }

        //Forms
        private void UIIntersetBearningDeposit_Load(object sender, EventArgs e)
        {
            LSum.Text = Math.Round(currentDepositor.interestBearingDeposit.amountInvested,2).ToString();
            LSumPercent.Text = currentDepositor.interestBearingDeposit.countFarmMoney.ToString();
            LDataStart.Text = currentDepositor.interestBearingDeposit.startTermin.ToString();
            LDateEnd.Text = currentDepositor.interestBearingDeposit.endTermin.ToString();
            LPercent.Text = Math.Round(currentDepositor.interestBearingDeposit.percent, 2).ToString();
        }

        //Buttons
        private void BComeBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Events 
        private void Form_Close(object sender, EventArgs e)
        {
            iBank.Show();
        }
    }
}
