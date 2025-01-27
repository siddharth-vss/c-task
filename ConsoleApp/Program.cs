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
            int[] marks = new int[5];
            int totalMarks = 0;

            // Loop to take input for 5 subjects
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter marks for subject {i + 1}:");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                totalMarks += marks[i];
            }

            // Calculate percentage
            double percentage = (double)totalMarks / 5;

            // Print total and percentage
            Console.WriteLine("Total Marks: {0}",totalMarks);
            Console.WriteLine("Percentage: {0}%",percentage);

            Console.ReadLine();
        }
    }
}
