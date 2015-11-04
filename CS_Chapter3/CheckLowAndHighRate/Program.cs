using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            double payrate;
            Console.Write("Please enter your payrate");
            payrate = Convert.ToDouble(Console.ReadLine());

            if (payrate < 5.65 || payrate > 49.99)
                Console.WriteLine("error");
        }
    }
}
