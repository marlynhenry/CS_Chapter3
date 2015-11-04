using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double hourlypayrate;
            Console.Write("Please enter you hourly pay rate: ");
            hourlypayrate = Convert.ToDouble(Console.ReadLine());

            int hoursworked;
            Console.Write("Please enter your hours worked: ");
                hoursworked = Convert.ToInt32(Console.ReadLine());

            double grosspay = hourlypayrate * hoursworked;
            double Tax = 0;

            if(grosspay <= 300.00)
            {
                Tax = .10;
            }
            else if (grosspay >= 300.01)
            {
                Tax = .12;
            }
            double total = grosspay -(grosspay * Tax);
            Console.WriteLine("Total: {0}", total.ToString("C"));
        }
    }
}
