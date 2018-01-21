using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tong, soDuong, soAm;
            tong = soDuong = soAm = 0;
            string tmp = "";
            ConsoleKeyInfo info;
            Console.WriteLine("Nhap so . Nhan Esc to thoat: ");
            do
            {
                info = Console.ReadKey();
                tmp += info.KeyChar.ToString();
                if (info.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    if (info.Key == ConsoleKey.Enter)
                    {
                        int a = Convert.ToInt32(tmp);
                        if (a >= 0) soDuong++;
                        else soAm++;
                        tong += a;
                        tmp = "";
                        Console.WriteLine();                  
                    }
                }
                
            } while (true);
            Console.WriteLine("\ntong la: " + tong + " ; so so duong la: " + soDuong + " ; so so am la: " + soAm);
            Console.ReadLine();
        }
    }
}
