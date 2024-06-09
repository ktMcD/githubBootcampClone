namespace CreatingApis.Models
{
    public class Bookstore
    {
        private static List<Bookstore> Stores = new List<Bookstore>();
        private static int NextId = 1;

        public int Id { get; set; }
        public string BookstoreName { get; set; }
        public string BookstoreCategory { get; set; }
        public string Location { get; set; }

        public List<Bookstore> GetAll()
        {
            return Stores;
        }

        public static Bookstore AddBookstore(string name, string category, string location)
        {
            Bookstore newStore = new Bookstore() { BookstoreName = name, BookstoreCategory = category, Location = location };
            Stores.Add(newStore);
            return newStore;
        }

        public static List<Bookstore> FindbyLocation(string location)
        {
            return Stores.Where(x=>x.Location.ToLower().Contains(location.ToLower())).ToList();
        }

        public static List<Bookstore> FindByStoreName(string name)
        {
            return Stores.Where(x => x.BookstoreName.ToLower().Contains(name.ToLower())).ToList();
        }

        public static Bookstore FindById(int id)
        {
            return Stores.FirstOrDefault(x => x.Id == id);
        }

        public static Bookstore FindByName(string name)
        {
            return Stores.FirstOrDefault(x => x.BookstoreName == name);
        }

    }
}
