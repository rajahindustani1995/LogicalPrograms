using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            Console.Write("Enter the Number to Revers : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;

            while (number != 0)
            {
                reverse *= 10;
                reverse += number % 10;
                number /= 10;
            }
            Console.WriteLine("Reversed Number is : " + reverse);
        }
    }
}
