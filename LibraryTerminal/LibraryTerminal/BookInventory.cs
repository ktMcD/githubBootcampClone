using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Xml.Serialization;

namespace LibraryTerminal
{
    public class BookInventory
    {
        public List<Book> Books = new List<Book>();

        const string bookInventoryDocPath = @"c:\Temp\BookInventory.txt";

        public BookInventory()
        {
            if (File.Exists(bookInventoryDocPath))
            {
                ReadInBookInventory();
            }
            else
            {
                PopulateBookInventory();
            }
        }

        public void PopulateBookInventory()
        {
            Books.Add(new Book("The Great Gasby", "F. Scott Fitzgerald"));
            Books.Add(new Book("War and Peace", "Leo Tolstoy"));
            Books.Add(new Book("The Odyssey", "Homer"));
            Books.Add(new Book("Hamlet", "William Shakespeare"));
            Books.Add(new Book("To Kill a Mockingbird", "Harper Lee"));
            Books.Add(new Book("The Giver", "Lois Lowry"));
            Books.Add(new Book("Help! My Teacher Hates Me!", "Meg F. Schneider"));
            Books.Add(new Book("Dark Psychology", "Ryan Watson"));
            Books.Add(new Book("Tequila Mockingbird", "Cpt. Cuervo Audobon"));
            Books.Add(new Book("The Alchemist", "Paulo Coelho"));
            Books.Add(new Book("The 48 Laws of Power", "Robert Green"));
            Books.Add(new Book("The Only Thing Mice are Good Fur is Nomnom", "Snowball"));
            Books.Add(new Book("1984", "George Orwell"));
            Books.Add(new Book("Harry Potter and the Philospher's Stone", "J.K. Rowling"));
            Books.Add(new Book("The Lord of the Rings", "J.R.R. Tolkien"));
        }

        public void DisplayBookList()
        {
            foreach (Book book in Books)
            {
                if (book.Status == BookStatus.OnShelf)
                {
                    Console.WriteLine($"{book.Title,-45} --- {book.Author,-25} --- {"Available",15}");
                }
                else
                {
                    Console.WriteLine($"{book.Title,-45} --- {book.Author,-25} --- Due: {book.DueDate,10:d}");
                }
            }

            Console.WriteLine();
        }

        public void RecordBookInventory()
        {
            StreamWriter bookInventoryRecorder = new StreamWriter(bookInventoryDocPath, false);
            if (Directory.Exists(@"c:\Temp"))
            {
                try
                {
                    foreach (Book book in Books)
                    {
                        bookInventoryRecorder.WriteLine($"{book.Title}|{book.Author}|{book.Status}|{book.DueDate:d}");
                    }

                    bookInventoryRecorder.Flush();
                    bookInventoryRecorder.Close();
                }
                catch (System.IO.IOException someMysteriousThing)
                {
                    bookInventoryRecorder.Flush();
                    bookInventoryRecorder.Close();
                    Console.WriteLine(someMysteriousThing.ToString());
                    return;
                }
            }
            else
            {
                // we could direct the program to add a directory here, but it's ok to just leave for now
                // and it's just impolite to create directories and stuff without permission
                Communication.TalkToUser("We can't write the book inventory to this local computer\n" +
                                         "because the temp directory on your c drive doesn't exist. Sorry!");
            }
        }

        public void ReadInBookInventory()
        {
            string rawText;
            string[] inventoryFields = new string[4];
            BookStatus bookStat;
            DateTime bookDueDate;

            StreamReader bookInventoryReader = new StreamReader(bookInventoryDocPath);
            while (true)
            {
                rawText = bookInventoryReader.ReadLine();
                if (rawText != null)
                {
                    inventoryFields = rawText.Split('|'); //using string.split() method to split the string.
                    bookStat = (BookStatus) Enum.Parse(typeof(BookStatus), inventoryFields[2]);
                    bookDueDate =
                        DateTime.Parse(inventoryFields[3]); // not need to validate since file is auto-generated
                    Books.Add(new Book(inventoryFields[0], inventoryFields[1], bookStat, bookDueDate));
                }
                // Leave the loop if the end of file is reached
                else
                {
                    break;
                }
            }

            bookInventoryReader.Close();
        }

        public List<Book> SearchBookByAuthor(string author)
        {
            var searchBookByAuthor =
                Books.Where(x => x.Author.Contains(author, StringComparison.InvariantCultureIgnoreCase)).Select(x => x)
                    .ToList();
            return searchBookByAuthor;
        }

        public void GetBookSearchValue(string titleOrAuthor)
        {
            IEnumerable<Book> searchResults = new List<Book>();
            string patronResponse;
            if (titleOrAuthor == "title")
            {
                Communication.TalkToUser("What title are you looking for?");
                patronResponse = Communication.ListenToUser();
                searchResults = SearchBookByTitle(patronResponse);
            }
            else
            {
                Communication.TalkToUser("What author are you looking for?");
                patronResponse = Communication.ListenToUser();
                searchResults = SearchBookByAuthor(patronResponse);
            }

            DisplaySearchResults(searchResults);
        }

        public List<Book> SearchBookByTitle(string theTitle)
        {
            var searchBookByTitle =
                Books.Where(x => x.Title.Contains(theTitle, StringComparison.InvariantCultureIgnoreCase)).Select(x => x)
                    .ToList();


            return searchBookByTitle;
        }

        public void DisplaySearchResults(IEnumerable<Book> searchResults)
        {
            foreach (Book book in searchResults)
            {
                if (book.Status == BookStatus.OnShelf)
                {
                    Console.WriteLine($"{book.Title,-45} --- {book.Author,-25} --- {"Available",15}");
                }
                else
                {
                    Console.WriteLine($"{book.Title,-45} --- {book.Author,-25} --- Due: {book.DueDate,10:d}");
                }
            }
        }

        public void CheckOutBook()
        {
            var title = "";
            bool tryAgain = true;

            while (tryAgain)
            {
                tryAgain = false;
                Communication.TalkToUser("What title are you checking out?");
                title = Communication.ListenToUser();
                foreach (Book book in Books.Where(x => x.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase)))
                {
                    if (book.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase) && book.Status == BookStatus.CheckedOut)
                    {
                        tryAgain = Navigation.TryAgain("book is checked out", title);
                        if (!tryAgain)
                        {
                            RecordBookInventory();
                            Navigation.ThankYouAndGoodbye();
                        }
                    }
                    book.DueDate = DateTime.Today.AddDays(14);
                    book.Status = BookStatus.CheckedOut;
                    Console.WriteLine("after set book status");
                }

                int titleResultsCount =
                    Books.Count(book => book.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase));

                if (titleResultsCount == 0)
                {
                    tryAgain = Navigation.TryAgain("book not found", title);
                    if (!tryAgain)
                    {
                        RecordBookInventory();
                        Navigation.ThankYouAndGoodbye();
                    }
                }
            }

            Communication.TalkToUser($"You have successfully checked out: {title}." +
                          $"Your Due date is {Books.Where(x => x.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase)).Select(x => x.DueDate.ToShortDateString()).FirstOrDefault()}." +
                          $"Thank you for using Library Console.{Environment.NewLine}");
        }

        public void ReturnABook()
        {   
            bool bookPastDue = false;
            bool tryAgain = true;
            DateTime oldDueDate;
            string title = "";
            while (tryAgain)
            {
                Communication.TalkToUser("What title are you checking in?");
                title = Communication.ListenToUser();
                tryAgain = false;
                foreach (Book book in Books.Where(x => x.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase)))
                {
                    if (book.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase) && book.Status == BookStatus.OnShelf)
                    {
                        tryAgain = Navigation.TryAgain("not checked out", title);
                        if (!tryAgain)
                        {
                            RecordBookInventory();
                            Navigation.ThankYouAndGoodbye();
                        }
                    }

                    oldDueDate = book.DueDate;
                    bookPastDue = oldDueDate < DateTime.Now;

                    book.DueDate = DateTime.Now;
                    book.Status = BookStatus.OnShelf;
                }

                int titleResultsCount =
                    Books.Count(book => book.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase));

                if (titleResultsCount == 0)
                {
                    tryAgain = Navigation.TryAgain("book not found", title);
                    if (!tryAgain)
                    {
                        RecordBookInventory();
                        Navigation.ThankYouAndGoodbye();
                    }
                }
            }

            if (bookPastDue)
            {
                Communication.TalkToUser(
                $"You have successfully checked in: {title}. Your book was returned late. Thank you for returning your book and using Library Console.{Environment.NewLine}");
                return;
            }
            
            Communication.TalkToUser(
                $"You have successfully checked in: {title}. Thank you for returning your book and using Library Console.{Environment.NewLine}");
        }
    }
}