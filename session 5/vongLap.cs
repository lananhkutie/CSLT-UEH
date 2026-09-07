using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_UEH.session_5
{
    internal class vongLap
    {
        static void BangCuuChuong()
        {
            Console.WriteLine("Bảng cửu chương:");
            for (int i = 2; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i} * {j} = {i * j}\t");
                }
                Console.WriteLine();
            }
        }
        static void Bai_1()
        { 
            Console.WriteLine("1. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.");
            Console.WriteLine("Nhập độ dài ba cạnh của tam giác:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a==b | a==c | b==c )
            {
                Console.WriteLine("Đây là tam giác cân");
            }
            else if (a==b && b==c && a==c)
            {
                Console.WriteLine("Đây là tam giác đều");
            }
            else
            {
                Console.WriteLine("Đây là tam giác thường");
            }     
        }
        static void Bai2()
        {
            Console.WriteLine("Write a program to read 10 numbers and find their average and sum");
            int sum = 0;
            int count = 10;
            float avg;
            for (int i= 1; i<= count; i++)
            {
                Console.WriteLine($"Nhập số thứ {i}");
                int number = int.Parse(Console.ReadLine());
                sum += number;

            }
            avg = (float)sum / count;
            Console.WriteLine($"Tổng 10 số là: {sum}");
            Console.WriteLine($"Trung bình 10 số là: {avg:F2}");

        }
        static void Bai3()
        {
            Console.WriteLine("Write a program to display the multiplication table of a given integer");
            Console.WriteLine("Nhập vào số nguyên bất kỳ:");
            int i = int.Parse(Console.ReadLine());
            for (int j =1; j<=10; j++)
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
            }

        }
        static void Bai4_5()
        {

        }
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Write a program to display a pattern like triangles with a number");
            Console.WriteLine("Nhập số dòng:");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "Hình 1:");
            for (int i =1; i<=n; i++)
            {
                for (int j=1; j<=i; j++ )
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("hình 2:");
            int so = 1;
            for (int i=1; i<=n; i++)
            {
                for ( int j=1; j<=i; j++ )
                {
                    Console.Write(so + "\t");
                    so++;
                }
                Console.WriteLine();
            }

        }
    }
}
