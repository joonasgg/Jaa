using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;
            do
            {
                Console.Write("Anna numero");
                number = int.Parse(Console.ReadLine());
                sum += number;

            } while (number != 0);

            Console.WriteLine("Summa on:" + sum);
            Console.ReadLine();
        }
    }
}
