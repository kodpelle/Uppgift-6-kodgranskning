using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class ListKlass
    {
        List<string> names = new List<string> { "Anna", "John", "Alice", "Börje" };

        public void PrintNames()
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
        public void SortedNames()
        {
            Console.WriteLine("Alfabetiskt sorterad lista:");
            names.Sort();
            PrintNames();
        }
        public void AddToList()
        {
            Console.WriteLine("skriv vilket namn du vill lägga till");
            string addname = Console.ReadLine().ToLower();
            names.Add(addname);
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("\nEnter name to search:");
            string searchName = Console.ReadLine();
            if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} is in the list.");
            }
            else
            {
                Console.WriteLine($"{searchName} is not in the list. ");
            }
            Console.ReadKey();
        }
        
    }
}
