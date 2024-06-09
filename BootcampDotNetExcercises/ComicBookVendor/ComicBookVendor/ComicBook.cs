using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookVendor
{
    public class ComicBook
    {
        private const double markUpTick = .02;
        private double markUpPercentage;

        public string UpcNumber { get; set; }
        public string Title { get; set; }
        public DateTime PurchasedDate { get; set; }
        public double PurchasePrice { get; set; }   
        public double CurrentValue { get; private set; }
        public string Artist { get; set; }

        public ComicBook()
        {

        }
        public ComicBook(string upc)
        {
            UpcNumber = upc;
            CurrentValue = 1;
        }

       public double CalculateStickerPrice()
        {
            return PurchasePrice + (PurchasePrice * markUpPercentage);
        }

        public double CalculateRoi()
        {
            return CalculateStickerPrice() - PurchasePrice;
        }

        public void UpdateCurrentValue(double newValue)
        {
            CurrentValue = newValue;
            UpdateMarkupPercentage();
        }

        private void UpdateMarkupPercentage()
        {
            markUpPercentage = CurrentValue * markUpTick;
        }

        public int CalculateDaysInInventory()
        {
            DateTime today = DateTime.Now;
            TimeSpan difference = today.Subtract(PurchasedDate);
            return difference.Days;
        }
         
    }
}
