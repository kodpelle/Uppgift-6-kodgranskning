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
        //metod för att se till så att strings har stor första bokstav och resten små. 
        public string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input; // Om strängen är tom eller null, returnera den som den är.

            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }
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
            string addname = Console.ReadLine();
            //använder min andra metod för att se till att första bokstaven blir stor och resten små.
            string formattedName = CapitalizeFirstLetter(addname);
            names.Add(formattedName);
        }
        //Metod för att söka i listan
        public void SearchName(string FindName)
        {
            //återanvänder metoden så att namn som läggs till också bara har stor första bokstav
            string formattedName = CapitalizeFirstLetter(FindName);
            if (names.Contains(formattedName))
            {
                Console.WriteLine($"{formattedName} Finns i listan.");
            }
            else
            {
                Console.WriteLine($"{formattedName} Finns inte i listan.");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
}
