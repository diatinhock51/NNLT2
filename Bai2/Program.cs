using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai2
{
    class Program
    {
        const int MAXLAP = 3;
        const int MAXSAI = 5;
        static void Main(string[] args)
        {
            int tong, soDuong, soAm, soLanLap, soLanSai, laSo = 1, viTriBatDau;
            tong = soDuong = soAm = soLanLap = soLanSai = 0;
            do
            {
                if (soLanLap == MAXLAP || soLanSai == MAXSAI) break;
                Console.Write("Nhap so : ");
                string tmp = Console.ReadLine();
                if (tmp[0] == '-') viTriBatDau = 1;
                else viTriBatDau = 0;
                for (int i = viTriBatDau; i < tmp.Length; i++)
                {
                    laSo = 1;
                    if (tmp[i] < '0' || tmp[i] > '9')
                    {
                        laSo = 0;
                        soLanLap++;
                        soLanSai++;
                        break;
                    }
                }
                if (laSo == 1)
                {
                    soLanLap = 0;
                    int a = Convert.ToInt32(tmp);
                    tong += a;
                    if (a >= 0) soDuong++;
                    else soAm++;
                }
            }
            while (true);
            Console.WriteLine("\n tong la : " + tong + " ; So so duong la: " + soDuong + " ; So so am la : " + soAm);
            Console.ReadLine();
        }
    }
}
