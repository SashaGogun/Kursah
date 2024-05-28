using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBA.Class
{
    public class BankSG
    {
        private static BankSG instance;
        private Dictionary<int, Depositor> accountsBank = new Dictionary<int, Depositor>();
        private BankSG(Dictionary<int, Depositor> dataFromJson) { accountsBank = dataFromJson; }
        public static BankSG Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BankSG(JsonHandler.LoadData());
                }
                return instance;
            }
        }
        public Dictionary<int, Depositor> getAllDepositor()
        {
            return accountsBank;
        }
        public bool checkAccount(int login, string password)
        {
            if (accountsBank.ContainsKey(login))
            {
                if (accountsBank[login].Password == password)
                    return true;
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool checkAccount(int login)
        {
            if (accountsBank.ContainsKey(login))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Depositor getDepositor(int login)
        {
            return accountsBank[login];
        }
        private int generateAccountNumber()
        {
            int randomAccountNumber = new Random().Next(100000000, 999999999);
            return randomAccountNumber;
        }
        public Depositor createBankAccount(string fio, string sex, int rnokpp, int numberOfPassport, string password, string issuedBy, DateTime issueDate, DateTime expiryDate)
        {
            int accountNumber;

            do accountNumber = generateAccountNumber();
            while (accountsBank.ContainsKey(accountNumber));

            Passport passport = new Passport(numberOfPassport, fio, sex, rnokpp, issuedBy, issueDate, expiryDate);
            Deposit check = new Deposit();
            InterestBearingDeposit interestBearingDeposit = new InterestBearingDeposit();
            accountsBank.Add(accountNumber, new Depositor(accountNumber, password, passport, check, interestBearingDeposit));
            return getDepositor(accountNumber);
        }
        public Dictionary<int, Depositor> getAllClient()
        {
            return accountsBank;
        }

    }
}
