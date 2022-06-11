using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class FibonacciSeries
    {
        public void Series()
        {
            Console.Write("Enter limit (Number > 2) up to which you want Fibonacci Series : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int first = 0;
            int second = 1;
            int next = first + second;
            if (Number > 2)
            {
                Console.Write("Fibonacci series is up to " + Number + " is : {0}, {1}, ", first, second);
                for (int i = 3; i <= Number; i++)
                {
                    if (i == Number)
                    {
                        Console.Write(next);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write(next + ", ");
                        first = second;
                        second = next;
                        next = first + second;
                    }
                }
            }
            else
            {
                Console.WriteLine("Entered number is either negative or too small fo Fibonacci Series");
            }
        }
    }
    
}
