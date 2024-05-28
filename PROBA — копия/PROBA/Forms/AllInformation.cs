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
    public partial class AllInformation : Form
    {
        UIBank iBank;
        Depositor currentDepositor;
        public AllInformation(UIBank iBank, Depositor currentDepositor)
        {
            InitializeComponent();
            this.iBank = iBank;
            this.currentDepositor = currentDepositor;
            this.FormClosing += Form_Close;
        }

        //logic
        private void BComeBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AllInformation_Load(object sender, EventArgs e)
        {
            LIOF.Text = currentDepositor.passport.FIO;
            LAccountNumber.Text = StaticMethod.AddSpaces(currentDepositor.AccountNumber.ToString());
            LCurrentCountMoney.Text = Math.Round(currentDepositor.deposit.CDA,2).ToString() + " UAH";
            LPassword.Text = currentDepositor.Password.ToString();
            LNumOfPassport.Text = currentDepositor.passport.NumberOfPassport.ToString();
            LSex.Text = currentDepositor.passport.Sex;
            LRNIKPP.Text = currentDepositor.passport.RNOKPP.ToString();
            LIssueDate.Text = currentDepositor.passport.IssueDate.ToString();
            LExpiryDate.Text = currentDepositor.passport.ExpiryDate.ToString();
            LLastDateOperation.Text = currentDepositor.deposit.LDO.ToString();
            LIssuedBy.Text = currentDepositor.passport.IssuedBy.ToString();
            LTypeOper.Text = currentDepositor.deposit.typeOperation.ToString();
        }

        //Events
        private void Form_Close(object sender, EventArgs e)
        {
            iBank.Show();
        }
    }
}
