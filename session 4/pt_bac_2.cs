using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_UEH.session_4
{
    internal class pt_bac_2
    {
        private static void Main1(string[] args)
        {
            //Giải pt bậc 2 bằng câu lệnh if else
            Console.WriteLine("Nhập a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập c: ");
            int c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phương trình có vô số nghiệm, x tùy ý");
                    }
                    else // b==0, c!=0
                    {
                        Console.WriteLine("vô lý");
                    }
                }
                else // b!=0
                {
                    double x = (double)(-c) / b;
                    Console.WriteLine($"Phương trình có nghiệm duy nhất: x = {x}");
                }
            }

            else //a!=0
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
                else if (delta == 0)
                {
                    double x = (double)(-b) / (2 * a);
                    Console.WriteLine($"Phương trình có nghiệm kép: x = {x}");
                }
                else if (delta > 0)
                {
                    double x1 = (double)(-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (double)(-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
                }
            }
        }

    }
}

