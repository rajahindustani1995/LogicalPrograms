using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PrimeNumber
    {
        public void Prime()
        {
            Console.Write("Enter the Number to check : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            int result = 0;

            if (number == 2)
            {
                Console.WriteLine("The numbe is a Prime Number");
            }

            if (number > 2)
            {
                for (int i = 2; i < number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        result = 1;
                        break;
                    }
                }
                if (result == 1)
                {
                    Console.WriteLine("Entered number is not a Prime Number");
                }
                else 
                {
                    Console.WriteLine("Entered number is a Prime Number");
                }
            }
            else
            {
                Console.WriteLine("Entered number is less than 2");
            }
        }
    }
}
