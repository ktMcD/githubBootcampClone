using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookVendor
{
    public class ComicBookSeries
    {
        private const double completionBonus = .05;
        public string SeriesName { get; set; }
        public Dictionary<string,ComicBook> InStockIssues { get; set; } = new Dictionary<string,ComicBook>();
        public int IssueCountForSeries { get; set; }

        public int CalculateNumberOfMissingIssues()
        {
            return IssueCountForSeries - InStockIssues.Count;
        }

        public void AddAComicBook(ComicBook book)
        {
            if (!InStockIssues.ContainsKey(book.UpcNumber))
            {
                InStockIssues.Add(book.UpcNumber, book);
            }            
        }

        public void RemoveAComicBook(string upc)
        {
            if (InStockIssues.ContainsKey(upc))
            {
                InStockIssues.Remove(upc);
            }
        }

        public double CalculateValueOfSeries()
        {
            List<ComicBook> books = InStockIssues.Values.ToList();
            return books.Sum(x => x.CurrentValue);
        }        
    }
}
