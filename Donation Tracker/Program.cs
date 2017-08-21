using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation_Tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("what is your address?");
            string address = Console.ReadLine();
            Console.WriteLine("What is your email address?");
            string emailAddress = Console.ReadLine();
            Console.WriteLine("What is the fiscal year?");
            string fiscal = Console.ReadLine();
            Console.WriteLine("How many quarters did you donate?");
            string quarters = Console.ReadLine();
            Console.WriteLine("How many one dollar bills did you donate?");
            string one = Console.ReadLine();
            Console.WriteLine("How many five dollar bills did you donate?");
            string five = Console.ReadLine();
            Console.WriteLine("How many ten dollar bills did you donate?");
            string ten = Console.ReadLine();
            Console.WriteLine("How many twentie dollar bills did you donate?");
            string twentie = Console.ReadLine();
            Console.WriteLine("How many fiftie dollar bills did you donate?");
            string fiftie = Console.ReadLine();
            Console.WriteLine("How many one hundred dollar bills did you donate?");
            string hundred = Console.ReadLine();
            
            Console.WriteLine("Here is your receipt");
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(emailAddress);
            Console.WriteLine(fiscal);
            double quarterTotals = double.Parse(quarters) * .25;
            double oneTotals = double.Parse(one) * 1;
            double fiveTotals = double.Parse(five) * 5;
            double tenTotals = double.Parse(ten) * 10;
            double twentieTotals = double.Parse(twentie) * 20;
            double fiftieTotals = double.Parse(fiftie) * 50;
            double hundredTotals = double.Parse(hundred) * 100;
            Console.WriteLine("Thank you for your donation of") ;
            Console.WriteLine(quarterTotals + oneTotals + fiveTotals + tenTotals + twentieTotals + fiftieTotals + hundredTotals);





            
        }
    }
}
