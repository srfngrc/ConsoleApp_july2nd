using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_july2nd
{


    class Program
    {
        static void Main(string[] args)
        {
            int integerNumber;
            int i;
            Console.WriteLine("Please enter an integer N:");
            int.TryParse(Console.ReadLine(), out integerNumber);

            for (i=1; i <= 10; i++)
            {
                Console.WriteLine(integerNumber + " x " + i + "=" + integerNumber * i);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
