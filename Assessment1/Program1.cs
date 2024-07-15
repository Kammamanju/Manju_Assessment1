using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    internal class Program1
    {
        static void Main()
        {
            double deposit = 1000;
            double interest = 5;
            int c = 0;
            while (deposit < 100000)
            {
                c++;
                double yearinterest = deposit * (interest / 100);
                deposit = deposit+yearinterest;
                Console.WriteLine(deposit);
            }
            Console.WriteLine("Total time it will take is "+c+" years");
        }
    }
}
