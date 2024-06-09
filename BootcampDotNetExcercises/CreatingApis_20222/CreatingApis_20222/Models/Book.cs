namespace CreatingApis_20222.Models
{
    public class Book
    {
        private static List<Book> Library = new List<Book>();
        private static int NextId = 1;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }

        public static List<Book> GetAll()
        {
            return Library;
        }
        public static Book FindById(int id)
        {
            return Library.FirstOrDefault(x => x.Id == id);
        }
        public static List<Book> FindByCategory(string category)
        {
            return Library.Where(x => x.Category.ToLower() == category.ToLower()).ToList();
        }

        public static Book AddBook(string title, string category)
        {
            Book newbook = new Book() { Id = NextId, Title = title, Category = category };
            NextId++;
            Library.Add(newbook);
            return newbook;
        }

    }

}
