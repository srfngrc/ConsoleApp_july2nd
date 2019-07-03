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

            WannaTryAgain();
        }

        private static void WannaTryAgain()
        {
            Console.WriteLine("Do you wanna calculate it for another integer? (Y/N)");
            string Answer = Console.ReadLine();
            if ((Answer == "Y") || (Answer == "y"))
            {
                CalculateSRFN();
            }
            else if ((Answer == "N") || (Answer == "n"))
            {
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Wrong character. Please enter just 'Y' or 'N'.");
                WannaTryAgain();
            }
            Console.ReadLine();
        }
    }
}
