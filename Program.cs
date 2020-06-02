using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void workingstings()
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

            Console.WriteLine();
            Console.WriteLine($"Ja sam: {names[0]}");
            Console.WriteLine($"Dodo sam: {names[2]} i {names[3]} na listu");
            Console.WriteLine($"Lista ima {names.Count} imena");

            var index = names.IndexOf("Filip");
            if (index==-1)
            {
                Console.WriteLine($"Kad itema nema, IndexOf vraca {index}");
            }
            else
            {
                Console.WriteLine($"Ime {names[index]} je na broju {index}");
            }
            index=names.IndexOf("Not Found");
            if (index==-1)
            {
                Console.WriteLine($"Kad itema nema, IndexOf vraca {index}");
            }
            else
            {
                Console.WriteLine($"Ime {names[index]} je na broju {index}");
            }
            Console.WriteLine();
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Bok {name.ToUpper()}!");
            } 
            
        }
        static void Main(string[] args)
        {
            //workingstings();
        }
    }
}
