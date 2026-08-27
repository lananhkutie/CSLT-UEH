using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSLT_UEH.session_4
{
    internal class Excercise_03LMS
    {
    static void bai_01()
    {
            Console.WriteLine("Bài 1: Kiểm tra số chẵn lẻ:");
            Console.WriteLine("Nhập mộ số nguyên bất kỳ:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} là số chẵn");
            }
            else
            {
                Console.WriteLine($"{number} là số lẻ");
            }
    }
    static void bai_02()
        {
            Console.WriteLine("Bài 2: tìm số lớn nhất trong 3 số");
            Console.WriteLine("Nhập số thứ nhất:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ hai:");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ ba:");
            double num3 = double.Parse(Console.ReadLine());
            double max = Math.Max(num1, Math.Max(num2, num3));
            Console.WriteLine($"Số lớn nhất trong 3 số là: {max}");

        }
    static void bai_03()
        {
            Console.WriteLine("Kiểm tra tam giác đều, vuông hoặc cân");
            Console.WriteLine("Nhập cạnh a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cạnh b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cạnh c:");
            double c = double.Parse(Console.ReadLine());
            if (a+b<=c || a+c<= b || b+c<=a)
            { 
                Console.WriteLine("Tam giác không hợp lệ!!");
            }
            else if (a==b && b==c && c==a)
            {
                Console.WriteLine("Đây là tam giác đều");
            }
            else if ( a==b || b==c || c==a)
            {
                Console.WriteLine("Đây là tam giác cân");
            }
        }
    static void bai_04()
        {
            Console.WriteLine("Nhập tọa độ x, y và kiểm tra thuộc góc phần tư nào");
            Console.WriteLine("Nhập x:");
            double x= double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập y:");
            double y= double.Parse(Console.ReadLine());
            if (x==y)
            {
                Console.WriteLine("Điểm thuộc gốc tọa độ");
            }
            else if (x>0 && y>0)
            {
                Console.WriteLine("Điểm thuộc góc phần tư thứ nhất");
            }
            else if (x<0 && y<0)
            {
                Console.WriteLine("Điểm thuộc góc phần tư thứ ba");
            }
            else if (x>0 && y<0)
            { 
                Console.WriteLine("Điểm thuộc góc phần tư thứ hai"); 
            }
            else if (x< 0 && y > 0)
            {
                Console.WriteLine("Điểm thuộc góc phần tư thứ tư");
            }
        }
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
        }
    }
}
