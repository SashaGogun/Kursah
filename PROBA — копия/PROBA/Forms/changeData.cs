﻿using PROBA.Class;
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
    public partial class changeData : Form
    {
        UIBank uIBank;
        Depositor currentDepositor;
        public changeData(UIBank uIBank, Depositor currentDepositor)
        {
            InitializeComponent();
            this.uIBank = uIBank;
            this.currentDepositor = currentDepositor;
            this.FormClosing += Form_Close;
            this.TNumberPassport.KeyPress += Event_KeyPress;
            this.Trnokpp.KeyPress += Event_KeyPress;
            this.TIssuedBy.KeyPress += Event_KeyPress;
            this.TName.KeyPress += FIO_KeyPress;
            this.TSurname.KeyPress += FIO_KeyPress;
            this.TThirdName.KeyPress += FIO_KeyPress;
            this.Sex.KeyPress += FIO_KeyPress;
            this.TPassword.KeyPress += Password_KeyPress;
        }

        private void changeData_Load(object sender, EventArgs e)
        {
            TName.Text = currentDepositor.passport.FIO.Split(' ')[1];
            TSurname.Text = currentDepositor.passport.FIO.Split(' ')[0];
            TThirdName.Text = currentDepositor.passport.FIO.Split(' ')[2];
            Sex.Text = currentDepositor.passport.Sex;
            TPassword.Text = currentDepositor.Password;
            Trnokpp.Text = currentDepositor.passport.RNOKPP.ToString();
            TNumberPassport.Text = currentDepositor.passport.NumberOfPassport.ToString();
            TIssuedBy.Text = currentDepositor.passport.IssuedBy.ToString();
            DIssueDate.Value = currentDepositor.passport.IssueDate;
            DExpityDate.Value = currentDepositor.passport.ExpiryDate;
        }

        //Logic button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BUpdateDate_Click(object sender, EventArgs e)
        {
            if(checkAllData())
            {
                currentDepositor.passport.UpdateDate(int.Parse(TNumberPassport.Text), $"{TSurname.Text} {TName.Text} {TThirdName.Text}", Sex.Text, int.Parse(Trnokpp.Text), TIssuedBy.Text, DIssueDate.Value, DExpityDate.Value);
                uIBank.UpDATE();
                MessageBox.Show("Дані оновлено");
                this.Close();
            }
        }

        //Events
        private void Form_Close(object sender, EventArgs e)
        {
            uIBank.Show();
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
        private void FIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Another function
        private bool checkAllData()
        {
            bool check = true;
            if (StaticMethod.ContainsNumbers(TName.Text) || TName.Text == "")
            {
                MessageBox.Show("Ви ввели не правильний формат імені людини.");
                TName.Text = "";
                check = false;
            }
            if (StaticMethod.ContainsNumbers(TSurname.Text) || TSurname.Text == "")
            {
                MessageBox.Show("Ви ввели не правильний формат прізвища людини.");
                TSurname.Text = "";
                check = false;
            }
            if (StaticMethod.ContainsNumbers(TThirdName.Text) || TThirdName.Text == "")
            {
                MessageBox.Show("Ви ввели не правильний формат по батькові людини.");
                TThirdName.Text = "";
                check = false;
            }
            if (Sex.Text.ToLower() != "ч" && Sex.Text.ToLower() != "ж")
            {
                MessageBox.Show("Веддіть букву: ч - (чоловік), ж - (жінка)");
                Sex.Text = "";
                check = false;
            }
            if (StaticMethod.IsStringConsistsOfNineDigits(Trnokpp.Text) == false || Trnokpp.Text == "")
            {
                MessageBox.Show("Ви ввели не правильний формат TRNOKPP.");
                Trnokpp.Text = "";
                check = false;
            }
            if (StaticMethod.IsStringConsistsOfNineDigits(TNumberPassport.Text) == false || TNumberPassport.Text == "")
            {
                MessageBox.Show("Ви ввели не правильний номер паспорта.");
                TNumberPassport.Text = "";
                check = false;
            }
            if (StaticMethod.IsStringConsistsOfDigits(TIssuedBy.Text, 4) == false || TIssuedBy.Text == "")
            {
                MessageBox.Show("Ви ввели не правильно інформацію про те ким був виданий паспорт.");
                TIssuedBy.Text = "";
                check = false;
            }
            if (DIssueDate.Value >= DExpityDate.Value)
            {
                MessageBox.Show("Ви ввели не правильно дату видачі паспорта.");
                check = false;
            }
            if (DExpityDate.Value <= DateTime.Now)
            {
                MessageBox.Show("Ви ввели не правильно дату закінчення терміну паспорта.");
                check = false;
            }
            return check;
        }
    }
}
