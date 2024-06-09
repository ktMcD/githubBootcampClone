using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandA
{
    public class DataStructureCode
    {
        public void ExecuteDataStructureCode()
        {
            LinkedList<string> names = new LinkedList<string>();
            names.AddFirst("Mary");

            names.AddBefore(names.Find("Mary"), "Jeff");
            names.AddAfter(names.Find("Mary"), "James");

            names.AddLast("Ann");

            foreach (string name2 in names)
            {
                Console.WriteLine(name2);
            }

            Console.ReadLine();

            names.AddAfter(names.Find("James"), "Joe");

            // Console.WriteLine(names[2]);
            // You have to traverse the nodes
            Console.WriteLine(names.First.Next.Next.Value);

            Queue<string> disneyLine = new Queue<string>();

            disneyLine.Enqueue("Jeff");
            disneyLine.Enqueue("Mary");
            disneyLine.Enqueue("James");
            disneyLine.Enqueue("Ann");

            // You can only access the last item that was added to the stack
            // PEEK lets you look at the item without removing it from the stack

            Console.WriteLine(disneyLine.Peek()); // Will display "Jeff"

            // You can't see "Mary" until you DEQUEUE "Jeff" out of the stack
            string nameD = disneyLine.Dequeue();
            Console.WriteLine(disneyLine.Peek()); // Will display "Mary"

            // Stacks
            Stack<string> guests = new Stack<string>();

            guests.Push("Jason");
            guests.Push("John");
            guests.Push("Grant");
            guests.Push("Talon");

            Console.WriteLine(guests.Peek());
            string name = guests.Pop();
            Console.WriteLine(guests.Peek());


            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }

            // Cant do this
            /*
            for(int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
            */

            Console.ReadKey();
        }
    }
}
