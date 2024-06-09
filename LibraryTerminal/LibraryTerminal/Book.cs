namespace LibraryTerminal
{
    public class Book
    {
        public DateTime today = DateTime.Today;
        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }
        public DateTime DueDate { get; set; } = new DateTime();


        public Book(string bookTitle, string bookAuthor, BookStatus bookStat, DateTime dueDate)
        {
            Title = bookTitle;
            Author = bookAuthor;
            Status = bookStat;
            DueDate = dueDate;
        }

        public Book(string bookTitle, string bookAuthor)
        {
            Title = bookTitle;
            Author = bookAuthor;
            Status = 0;
        }
    }
}