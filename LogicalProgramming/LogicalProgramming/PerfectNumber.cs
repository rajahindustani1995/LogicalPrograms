using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PerfectNumber
    {
        public void Perfect()
        {
            Console.Write("Enter the number for Perfect Number calculation : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            //Divisors calculation logic
            Console.Write("Divisors are : ");
            for (int i = 1; i <= (Number / 2); i++)
            {
                if (Number % i == 0)
                {
                    Console.Write(i + " ");
                    result += i;
                }
            }
            Console.WriteLine("\nAddition of Divisors is : " + result);
            if (result == Number)
            {
                Console.WriteLine("The Entered Number is a Perfect Number");
            }
            else
            {
                Console.WriteLine("The Entered Number is not a Perfect Number");
            }

        }
    }
}
