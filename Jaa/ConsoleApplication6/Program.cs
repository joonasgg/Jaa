using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1;
            Console.Write("Anna luku 1");
            luku1 = int.Parse(Console.ReadLine());
            int luku2;
            Console.Write("Anna luku 2");
            luku2 = int.Parse(Console.ReadLine());
            int luku3;
            Console.Write("Anna luku 3");
            luku3 = int.Parse(Console.ReadLine());

            if (luku1 > luku2 && luku1 < luku3)
            {
                Console.WriteLine("Suurin luku on:" + luku1);
            }
            else {
                if (luku2 > luku1 && luku2 > luku3)

                {
                    Console.WriteLine("Suurin luku on:" + luku2);
                }
                else
                {
                    Console.WriteLine("Suurin luku on:" + luku3);
                }
            }
        }
    }
}
