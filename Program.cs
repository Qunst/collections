using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //workingstings();
            numberlist();
        }
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
        static void numberlist()
        {
            var fibonacciNumbers=new List<int> {1,1};
            var previous=fibonacciNumbers[fibonacciNumbers.Count-1];
            var previous2=fibonacciNumbers[fibonacciNumbers.Count-2];

            fibonacciNumbers.Add(previous+previous2);

            //foreach (var item in fibonacciNumbers)
            //    Console.WriteLine(item);

            for (int i=0; i<20; i++)
            {
                Console.WriteLine(fibonacciNumbers[i]);
                previous=fibonacciNumbers[fibonacciNumbers.Count-1];
                previous2=fibonacciNumbers[fibonacciNumbers.Count-2];
                fibonacciNumbers.Add(previous+previous2);
            }
        }
        
    }
}
