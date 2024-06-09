using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class ComicBook
    {
        public string name;
        public int quantity;
        public double price;

        public ComicBook(string bookName, int amount, double cost)
        {
            name = bookName;
            quantity = amount;
            price = cost;
        }

        public ComicBook()
        {
            name = "unknown";
        }

        public double CalculateSubTotal()
        {
            return quantity * price;
        }
    }
}
