using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBA.Class
{
    public class Depositor
    {
        public int AccountNumber { get; private set; }
        public string Password { get; private set; }
        public Deposit deposit { get; private set; }
        public Passport passport { get; private set; }
        public InterestBearingDeposit interestBearingDeposit { get; private set; }
        public Depositor(int accountNumber, string password, Passport passport, Deposit deposit, InterestBearingDeposit interestBearingDeposit)
        {
            AccountNumber = accountNumber;
            Password = password;
            this.passport = passport;
            this.deposit = deposit;
            this.interestBearingDeposit = interestBearingDeposit;
        }
        public void upDateInterestBearingDeposit(InterestBearingDeposit NewInterestBearingDeposit)
        {
            this.interestBearingDeposit = NewInterestBearingDeposit;
        }
    }
}
