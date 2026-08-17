using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_UEH.session02
{
    internal class Exercises_01
    {
        private static void Main(string[] args)
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

        }
    }
}
