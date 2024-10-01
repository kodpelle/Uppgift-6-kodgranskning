﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class Listklass
    {
        public List<string> names = new List<string> { "Anna", "John", "Alice", "Börje" };
    }
     class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Original list");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names.Sort();
            Console.WriteLine("\nSorted list:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
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
