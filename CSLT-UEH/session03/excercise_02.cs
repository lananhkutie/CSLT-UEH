using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CSLT_UEH.session02
{
    internal class Exercises_02
    {
        static void bai1_slide()
        {//to convert from degrees Celsius to Kelvin and Fahrenheit
            Console.WriteLine("nhap nhiet do C:");
            float celcius;
            while (true)
            {
                string input = Console.ReadLine();
                if (float.TryParse(input, out celcius))
                {
                    Console.WriteLine($" do Kelvin = {celcius + 273}");
                    Console.WriteLine($" do Fahrenheit = {celcius * 1.8 + 32}");
                    break;
                }
                else
                {
                    Console.WriteLine("Du lieu khong hop le. Vui long nhap lai:");

                }
            }
        }
        static void bai2_slide()
        {   //Create a program in C# for calculate the surface and volume of a sphere, given its radius.
            Console.WriteLine("Nhap ban kinh hinh cau:");
            double radius;
            while (true)
            {
                string? input = Console.ReadLine();
                if (double.TryParse(input, out radius)) ;
                {
                    Console.WriteLine($"The tich hinh cau la: {radius * radius * radius * 4 / 3 * Math.PI}");
                    break;
                }
                Console.WriteLine("sai dinh dang. Vui long nhap lai:");
            }
        }
        static void bai3_slide()
        {
            //Write a program in C# that calculates the result of adding, subtracting, multiplying and dividing two numbers entered by the user.
            double num1, num2;
            while (true)
            {
                Console.WriteLine("Nhap so thu nhat:");
                string input1 = Console.ReadLine();
                if (double.TryParse(input1, out num1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Du lieu khong hop le. Vui long nhap lai:");
                }
            }
            while (true)
            {
                Console.WriteLine("Nhap so thu hai:");
                string input2 = Console.ReadLine();
                if (double.TryParse(input2, out num2) && num2 != 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Du lieu khong hop le. Vui long nhap lai:");
                }
            }
            Console.WriteLine($"Tong cua hai so la: {num1 + num2}");
            Console.WriteLine($"Hieu cua hai so la: {num1 - num2}");
            Console.WriteLine($"Tich cua hai so la: {num1 * num2}");
            
            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //bai1_slide();
            //bai2_slide();
            //bai3_slide();
            decimal csd_cu;
            decimal csd_moi;
            Console.WriteLine("nhap chi so dien cu");

        }
    }
}
