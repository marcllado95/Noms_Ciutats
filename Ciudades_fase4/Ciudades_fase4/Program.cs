using System;

namespace Ciudades_fase4
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

            string[] cities = { a, b, c, d, e, f };   //guardem les variables al array "cities"

            Console.WriteLine("Ciutats girades: ");

            for (int i = 0; i < cities.Length; i++)
            {
                char[] lletres_city = new char[cities[i].Length];

                for (int j = 0; j < cities[i].Length; j++)
                {
                    lletres_city[j] = cities[i][j];    //omplim un nou array de lletres per cada ciutat
                }

                
                Console.Write(cities[i] + " - ");

                for (int j = cities[i].Length-1 ; j >= 0; j--)   //creem aquest bucle per mostrar l'array invertit
                {  
                    Console.Write(lletres_city[j]);
                }

                Console.WriteLine();
                
            }
        }
    }
}
