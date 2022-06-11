using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class StopWatch
    {
        

        public void Watch()
        {
            Console.WriteLine("Press Enter to Start the StopWatch.");
            Console.ReadLine();
            DateTime Start = DateTime.Now;

            Console.WriteLine("Press Enter to Stop the StopWatch.");
            Console.ReadLine();
            DateTime Stop = DateTime.Now;

            Console.WriteLine("Elapsed Time is = " + (Stop - Start));
        }
    }
}
