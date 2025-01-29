using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LINQ
{
    internal class ThreadExample
    {
        static void display()
        {
            for (int i = 1; i<= 10; i++)
            {
                Console.WriteLine($"process {i}");
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args) {
            ThreadStart th = new ThreadStart(ThreadExample.display);
            Thread t = new Thread(th);
            t.Start();
        }
    }
}