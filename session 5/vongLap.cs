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

            Console.WriteLine("Write a program to display a pattern like triangles with a number");
            Console.WriteLine("Nhập số dòng:");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hình 1:");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("hình 2:");
            int so = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(so + "\t");
                    so++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("hình 3:");
            int number = 1;
            for (int i =1; i<=n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(". ");
                }
                for (int t=1; t<=i; t++)
                {
                    Console.Write(number);
                    Console.Write(" ");
                    number++;
                }
                Console.WriteLine();
            }
        }
        static void Bai6()
        {
            Console.WriteLine("Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms");
            int i = int.Parse(Console.ReadLine());
            float sum = 0;
            for (int j = 1; j <= i; j++)
            {
                sum = sum + 1.0f / j;
            }
            Console.WriteLine($"Sum of harmonic series: {sum}");
        }
        static void Bai7()
        {

            Console.WriteLine("Write a program to find the ‘perfect’ numbers within a given number range.");
            // số hoàn hảo là số mà tổng các ước số của nó (ngoại trừ chính nó) bằng chính nó. Ví dụ: 6 là số hoàn hảo vì 1 + 2 + 3 = 6.
            Console.Write("Nhập số cần kiểm tra:");
            int num= int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i =1; i<= num/2; i++)
            {
                if (num % i==0)
                {
                    sum += i;
                }
            }

            if (sum == num)
            {
                Console.WriteLine($"{num} là số hoàn hảo");
            }
            else
            {
                Console.WriteLine($"{num} không phải là số hoàn hảo");
            }
        }
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Write a program to determine whether a given number is prime or not.");
            Console.WriteLine("Nhập số cần kiểm tra:");
            int num = int.Parse(Console.ReadLine());
            bool prime = true;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine($"{num} là số nguyên tố");
            }
                else
                {
                    Console.WriteLine($"{num} không phải là số nguyên tố");
                }
            


            
        }
    }
}
