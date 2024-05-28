using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBA.Class
{
    public class Deposit
    {
        public double CDA { get; set; }
        public DateTime LDO { get; set; }
        public string typeOperation { get; set; } = ""; //Поповнення рахунку. Переказ грошів. Зняття коштів з рахунку.
        public double lastSumOp { get; set; }

        public void TopUpCheck(double sum)
        {
            CDA += sum;
            CDA = Math.Round(CDA, 2);
            setLasDateOperation();
            lastSumOp = sum;
            typeOperation = "Поповнення рахунку";
        }
        public void WithDrawCheck(double sum)
        {
            CDA -= sum;
            CDA = Math.Round(CDA, 2);
            setLasDateOperation();
            lastSumOp = sum;

            typeOperation = "Зняття коштів з рахунку";
        }

        public void setTypeOperTran(double sum)
        {
            typeOperation = "Переказ грошів";
            lastSumOp = sum;
        }
        private void setLasDateOperation()
        {
            LDO = DateTime.Now;
        }
    }
}
