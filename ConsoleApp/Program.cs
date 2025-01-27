using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            int num3 = int.Parse(Console.ReadLine());

            // Compare the numbers using if-else if
            int biggest;

            if (num1 > num2 && num1 > num3)
            {
                biggest = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                biggest = num2;
            }
            else
            {
                biggest = num3;
            }

            // Display the biggest number
            Console.WriteLine($"The biggest number is: {biggest}");
            Console.ReadLine();
        }
    }
}
