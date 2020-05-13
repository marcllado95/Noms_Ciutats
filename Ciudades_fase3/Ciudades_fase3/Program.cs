using System;

namespace Ciudades_fase3
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
            string[] modif_cities = new string[6];

            Console.WriteLine("Ciutats ordenades alfabèticament:");
                       
            for (int i = 0; i < cities.Length; i++)
            {
                modif_cities[i] = cities[i].Replace('a', '4');
                
            }
            
            Array.Sort(modif_cities);

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(modif_cities[i]);
            }            
        }
    }
}
