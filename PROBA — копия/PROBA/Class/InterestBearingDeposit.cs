using PROBA.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBA.Class
{
    public class InterestBearingDeposit
    {
        public bool IsThereDeposit { get; set;}
        public double amountInvested { get; set;}
        public double percent { get; set;}
        public DateTime endTermin { get; set;}
        public DateTime startTermin { get; set;}
        public float countFarmMoney { get; set;}
        private DateTime lastFarmDate;

        public InterestBearingDeposit(bool isThereDeposit, double amountInvested, double percent, DateTime endtermin)
        {
            IsThereDeposit = isThereDeposit;
            this.amountInvested = amountInvested;
            this.percent = percent;
            this.endTermin = endtermin;
            this.startTermin = DateTime.Now;
            this.countFarmMoney = 0;
        }
        public InterestBearingDeposit()
        {
            IsThereDeposit = false;
            this.amountInvested = 0;
            this.percent = 0;
            this.endTermin = DateTime.MinValue;
            this.startTermin = DateTime.MinValue;
            this.countFarmMoney = 0;
        }

        public void UpDateFarmMoney(Depositor currentDeposit, UIBank uIBank)
        {
            DateTime currentDate = DateTime.Now;
            if(currentDeposit.interestBearingDeposit.IsThereDeposit)
            {
                if (currentDate.Date <= endTermin.Date && currentDate.Date != lastFarmDate.Date)
                {
                    this.countFarmMoney = (float)Math.Round(((amountInvested * (percent) * countDays(startTermin, currentDate)) / 365), 2);
                    this.lastFarmDate = currentDate;
                }
                if(this.lastFarmDate.Date == this.endTermin.Date)
                {
                    currentDeposit.deposit.TopUpCheck(amountInvested + (float)((amountInvested * (percent) * countDays(startTermin, endTermin)) / 365));
                    currentDeposit.upDateInterestBearingDeposit(new InterestBearingDeposit());
                    uIBank.UpDATE();
                }
            }
        }

        private int countDays(DateTime start, DateTime end)
        {
            DateTime startDate = start;
            DateTime endDate = end;
            TimeSpan difference = endDate - startDate;
            int numberOfDays = difference.Days;
            return numberOfDays;
        }
    }
}
