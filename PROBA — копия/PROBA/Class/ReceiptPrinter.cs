using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBA.Class
{
    static class ReceiptPrinter
    {
        private static string receiptText;

        public static void AskToPrintReceipt(string textToPrint)
        {
            DialogResult result = MessageBox.Show("Чи потрібно роздрукувати чек?", "Друк чека", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PrintReceipt(textToPrint);
            }
        }

        public static void PrintReceipt(string textToPrint)
        {
            receiptText = textToPrint; 

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private static void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Друк тексту чека
            e.Graphics.DrawString(receiptText, new Font("Arial", 12), Brushes.Black, 100, 100);
        }
    }
}
