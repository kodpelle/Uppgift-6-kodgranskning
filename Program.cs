using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class ListKlass
    {
        //Jag behåller datastrukturen lista eftersom vi bara hanterar strings med namn, det är enklast och mest effektivt när det är en liten simpel lista.
        List<string> names = new List<string> { "Anna", "John", "Alice", "Börje" };

        //ett förbättrat sätt att skriva ut innehållet i listan, går att återanvända
        public void PrintNames()
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
        //om man vill sortera listan så kan man skriva en metod, mindre kod i main.
        public void SortedNames()
        {
            Console.WriteLine("Alfabetiskt sorterad lista:");
            names.Sort();
            PrintNames();
        }
        //Man kanske vill lägga till någon i listan då kan man göra det i konsollen
        public void AddToList()
        {
            Console.WriteLine("skriv vilket namn du vill lägga till");
            string addname = Console.ReadLine().ToLower();
            names.Add(addname);
        }
        //Metod för att söka i listan
        public void SearchName(string FindName)
        {
            if (names.Contains(FindName))
            {
                Console.WriteLine($"{FindName} Finns i listan.");
            }
            else
            {
                Console.WriteLine($"{FindName} Finns inte i listan.");
            }
            
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            /*

            Console.WriteLine("\nEnter name to search:");
            string searchName = Console.ReadLine();
            if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} is in the list.");
            }
            else
            {
                Console.WriteLine($"{searchName} is not in the list. ");
            }*/
            Console.ReadKey();
        }
        
    }
}
