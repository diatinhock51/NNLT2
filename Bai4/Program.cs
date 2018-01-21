using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += 2 * i + 1;
            }
            Console.WriteLine(" tong = {0} ", tong);
            Console.ReadLine();
        }
    }
}
