using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PROBA.Class
{
    public class Passport
    {
        public int NumberOfPassport { get; private set; }
        public string FIO { get; private set; }
        public string Sex { get; private set; }
        public int RNOKPP { get; private set; }
        public string IssuedBy { get; private set; } //(Ким виданий)
        public DateTime IssueDate { get; private set; }//(Дата видачі)
        public DateTime ExpiryDate { get; private set; }//(Дата закінчення терміну дії)

        [JsonConstructor]
        public Passport(int numberOfPassport, string fio, string sex, int rnokpp, string issuedBy, DateTime issueDate, DateTime expiryDate)
        {
            NumberOfPassport = numberOfPassport;
            FIO = fio;
            IssueDate = issueDate;
            IssuedBy = issuedBy;
            ExpiryDate = expiryDate;
            Sex = sex;
            RNOKPP = rnokpp;
        }
    
        public void UpdateDate(int NumberOfPassport, string FIO, string Sex, int RNOKPP, string IssuedBy, DateTime IssueDate, DateTime expiryDate)
        {
            this.NumberOfPassport = NumberOfPassport;
            this.FIO = FIO;
            this.Sex = Sex;
            this.RNOKPP = RNOKPP;
            this.IssuedBy = IssuedBy;
            this.IssueDate = IssueDate;
            this.ExpiryDate = expiryDate;
        }
        public void checkDateOfPassport()
        {
            if (ExpiryDate <= DateTime.Now)
            {
                MessageBox.Show("Вам потрібно оновити дані паспорта.");
            }
        }
    }
}
