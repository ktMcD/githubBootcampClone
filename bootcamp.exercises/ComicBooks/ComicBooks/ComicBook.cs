using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBooks
{
    public class ComicBook
    {
        public string name;
        public double price;
        public int quantity;

        public ComicBook(string comicBookname, double comicBookprice, int comicBookquantity)
        {
            name = comicBookname;
            price = comicBookprice;
            quantity = comicBookquantity;
        }

        public double CalculateTotal(double price, int quantityomicBookQuFD)
        {
            double subtotal;
            return price * quantity;
        }
    } // end class ComicBook
}
