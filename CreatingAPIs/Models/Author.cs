namespace CreatingApis.Models
{
    public class Author
    {
        private static List<Author> AuthorList = new List<Author>();
        private static int NextId = 1;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberOfTitles { get; set; }

        public static Author AddAuthor(string firstName, string lastName, int titleCount)
        {
            Author newAuthor = new Author() { Id = NextId, FirstName = firstName, LastName = lastName, NumberOfTitles = titleCount };
            NextId++;
            AuthorList.Add(newAuthor);
            return newAuthor;
        }

        public static List<Author> GetAll()
        {
            return AuthorList;
        }

        public static List<Author> FindByString(string text)
        {
            return AuthorList.Where(x => x.FirstName.ToLower().Contains(text.ToLower()) || x.LastName.ToLower().Contains(text.ToLower())).ToList();
        }

        public static List<Author> GetByTitleCount(int titleCount)
        {
            return AuthorList.Where(x => x.NumberOfTitles >= titleCount).ToList();
        }
    }

}
