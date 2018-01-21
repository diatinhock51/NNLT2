using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, max;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            max = a > b ? a : b;
            max = max > c ? max : c;
            Console.WriteLine(" Max = {0} ", max);
            Console.ReadLine();
        }
    }
}
