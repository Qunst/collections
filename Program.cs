using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var names=new List<string> {"Dado", "Ana", "Filip"};
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");             
            }
            Console.WriteLine();
            names.Add("Marija");
            names.Add("Franc");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");             
            }
                
        }
    }
}
