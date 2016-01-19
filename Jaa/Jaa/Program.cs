using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaa
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
            Console.WriteLine("Lukujen summa on" + (luku1+luku2+luku3));
        }
    }
}
