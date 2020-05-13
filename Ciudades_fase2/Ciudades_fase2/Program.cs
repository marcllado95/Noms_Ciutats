using System;

namespace Ciudades_fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c, d, e, f;

            Console.WriteLine("Introdueix el nom de les 6 ciutats");

            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            d = Console.ReadLine();
            e = Console.ReadLine();
            f = Console.ReadLine();

            string[] cities = { a, b, c, d, e, f }; //guardem les variables al array "cities"

            Console.WriteLine("Ciutats ordenades alfabèticament:");
            
            Array.Sort(cities);

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }
        }
    }
}
