using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(1 + "\t ");
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0) Console.Write(i + "\t ");
            }
            Console.ReadLine();
        }
    }
}
