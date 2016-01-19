using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Anna matka");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Bensaa kuluu:" + number * 0.0702 );
            Console.WriteLine("Rahaa kuluu:" + number * 0.11196);
        }
    }
}
