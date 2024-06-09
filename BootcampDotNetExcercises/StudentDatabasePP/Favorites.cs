using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabasePP
{
    public class Favorites
    {
        public string Food { get; set; }
        public string Color { get; set; }
        public string Movie { get; set; }
        public string Book { get; set; }

        public Favorites(string food, string color, string movie, string book)
        {
            Food = food;
            Color = color; 
            Movie = movie;
            Book = book;
        }

        public string GetFavorite(string item)
        {
            string value = "";
            switch (item.ToLower().Trim())
            {
                case "food":
                    value = Food;
                    break;
                case "color":
                    value = Color;
                    break;
                case "movie":
                    value = Movie;
                    break;
                case "book":
                    value = Book;
                    break;
                default:
                    value = "unknown";
                    break;
            }
            return $"The favorite {item} is {value}";
        }

    }
}
