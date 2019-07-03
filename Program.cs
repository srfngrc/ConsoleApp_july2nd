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
            CalculateSRFN();
        }
        static private void CalculateSRFN()
        {
            int integerNumber;
            int i;
            Console.WriteLine("Please enter an integer N:");
            int.TryParse(Console.ReadLine(), out integerNumber);

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(integerNumber + " x " + i + "=" + integerNumber * i);
                Console.WriteLine();
            }

            Console.WriteLine("Do you wanna calculate it for another integer? (Y/N)");
            string Answer = Console.ReadLine();
            if (Answer == "Y")
            {
                CalculateSRFN();
            }
            else if (Answer == "N")
            {
                System.Environment.Exit(1);
                //Application.Exit();
            }
            else
            {
                Console.WriteLine("Wrong character. Please enter just 'Y' or 'N'.");
                System.Environment.Exit(1);
            }
            Console.ReadLine();
        }

    }
}
