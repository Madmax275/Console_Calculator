using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            Console.WriteLine("After entering the first number, press <Enter> also after the second number.");
            int a = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select an operation: +,-,*,/,%");
            string b = Console.ReadLine();
            switch (b)
            {
                case "+":
                  int d = a + c;
                    if (d<0)
                    {
                        Console.WriteLine("The sum of the numbers cannot be negative");
                    }
                    else
                    {
                        Console.WriteLine("Sum of numbers: " + d);
                    }
                    
                    break;
                case "-":
                    int z = a - c;
                    if (z<0)
                    {
                        Console.WriteLine("The answer cannot contain a negative number");
                    }
                    else
                    {
                        Console.WriteLine("Difference of numbers :" + z);
                    }
                    break;
                case "*":
                    int v = a * c;
                    Console.WriteLine("The product of numbers :" + v);
                    break;
                case "/":
                    int w = a / c;
                    Console.WriteLine("Private :" + w);
                    break;
                case "%":
                    double r = a % c;
                    Console.WriteLine("The remainder of the number :" + r);
                    break;
                default:
                    break;
                   
            }
            Console.Read();
        }
    }
}
