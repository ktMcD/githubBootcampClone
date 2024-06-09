using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDbWithIO
{
    public class Document
    {
        public void WriteDataToFile()
        {

        }

        public void ReadDataFromFile()
        {

        }

        public void ListAllStudents()
        {
            Console.WriteLine("ID\tName\t\tHome Town\t\t Favorite Food");
            for (int i = 0; i < names.Length; i++)
            {
                int j = i + 1;
                Console.WriteLine($"{j}\t{names[i]}\t\t{homeTowns[i]}\t\t {faveFoods[i]} ");
            }
            return;
        }
    }
}
