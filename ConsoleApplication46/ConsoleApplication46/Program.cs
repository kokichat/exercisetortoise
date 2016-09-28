using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication46
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededHours = double.Parse(Console.ReadLine());
            double deadlineDays = double.Parse(Console.ReadLine());
            double extraWorkers = double.Parse(Console.ReadLine());

            double workDays = deadlineDays - (deadlineDays * 0.1);
            double strandarHours = workDays * 8;
            double exraHours = extraWorkers * (deadlineDays * 2);
            double totalHours = exraHours + strandarHours;;
            if (totalHours >= neededHours)
            {
                double hoursLeft = totalHours - neededHours;
                Console.WriteLine("Yes!" + Math.Ceiling(hoursLeft) + " hours left.");
            }
            else
            {
                double timeNeeded = neededHours - totalHours;
                Console.WriteLine("Not enough time!" + Math.Ceiling(timeNeeded) + " hours needed.");
            }
        }
    }
}
