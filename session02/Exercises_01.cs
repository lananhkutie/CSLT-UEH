using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CSLT_UEH.session02
{
    internal class Exercises_01
    {
        private static void Main1(string[] args)
        {
            //Câu 1 : Viết chương trình nhập vào hai số nguyên và in ra tổng của chúng.
            Console.WriteLine("Hello, my name is Anh");
            Console.WriteLine("Câu 1");
            Console.WriteLine("Nhap so dau tien:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tong cua hai so la: {a + b}");

            //Câu 2: đổi giá trị của 2 số
            Console.WriteLine("Câu 2");
            Console.WriteLine("Nhap so dau tien:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai:");
            int d = Convert.ToInt32(Console.ReadLine());
            int c1 = d; int d1 = c;
            Console.WriteLine($"Sau khi doi gia tri: so thu nhat la: {c1} \n So thu hai la: {d1}");

            //Câu 3: Nhân 2 số thực
            Console.WriteLine("Câu 3");
            Console.WriteLine("nhap so thuc dau tien:");
            float e = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap so thuc thu hai:");
            float f = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Nhan hai so thuc ta duoc:{e * f}");

            //Câu 4: Đổi đơn vị từ Feet sang met
            Console.WriteLine("Câu 4");
            Console.WriteLine("Nhap so feet:");
            double feet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{feet} feet= {feet * 0.3048} met");

            //Câu 5:to convert Celsius to Fahrenheit and vice versa
            Console.WriteLine("Câu 5");
            Console.WriteLine("Nhap do C:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap do F:");
            double Farrentheit= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{celsius} do C = {celsius * 1.8 + 32} do F");
            Console.WriteLine($"{Farrentheit} do F = {(Farrentheit - 32) / 1.8} do C");

            //Câu 6:to find the Size of data types
            Console.WriteLine("Câu 6");
            Console.WriteLine($"Size of int: {sizeof(int)} bytes");
            Console.WriteLine($"Size of float: {sizeof(float)} bytes");
            Console.WriteLine($"Size of double: {sizeof(double)} bytes");
            Console.WriteLine($"Size of char: {sizeof(char)} bytes");
            Console.WriteLine($"Size of bool: {sizeof(bool)} bytes");

            //Câu 7:to Print ASCII Value (tip: read character, print number of this char)
            Console.WriteLine("Câu 7");
            Console.WriteLine("Nhap mot ky tu:");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"ASCII value of {ch} is: {(int)ch}");

            //8. to Calculate Area of Circle
            Console.WriteLine("Câu 8");
            Console.WriteLine("Nhap duong kinh hinh tron:");
            float radius= Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"dien tich hinh tron la: {Math.PI * radius * radius}");

            //9.to Calculate Area of Square
            Console.WriteLine("Câu 9");
            Console.WriteLine("Nhap canh hinh vuong:");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"dien tich hinh vuong la: {side * side}");

            //10.to convert days to years, weeks and days
            Console.WriteLine("Câu 10");
            Console.WriteLine("Nhap so ngay:");
            int days = Convert.ToInt32(Console.ReadLine());
            int years = days / 365;
            int weeks = (days % 365) / 7;
            int remainingDays = (days % 365) % 7;
            Console.WriteLine($"{days} ngay = {years} nam, {weeks} tuan, {remainingDays} ngay");



        }
    }
}
