using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT_UEH.session_4
{
    internal class excercise_01
    {
        static void Bai_1()
        {
            Console.WriteLine("Bài 1: Viết chương trình C# Sharp nhận hai số làm đầu vào thực hiện một phép toán (+, -, *, %, /) trên chúng và hiển thị kết quả của phép toán.");
            //Write a C# Sharp program that takes two numbers as input performs an operation(+, -, *, %,/) on them and displays the result of operation.
            Console.WriteLine("Nhập số thứ nhất");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ 2");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

        }
        static void Bai_2()
        {
            Console.WriteLine("Bài 2: Viết chương trình C# Sharp để hiển thị các giá trị nhất định của hàm x = y2 + 2y + 1 (sử dụng số nguyên cho y, từ -5 đến +5).");
            //Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1(using integer numbers for y, ranging from - 5 to + 5).
            int x;
            for (int y = -5; y <= 5; y++)
            {
                x = (y * y) + 2 * y + 1;
                Console.WriteLine($"y = {y}, x = {x}");
            }
        }
        static void Bai_3()
        {
            //Write a C# Sharp program that takes distance and time (hours, minutes seconds) as input and displays speed in kilometers per hour(km / h) miles per hour(miles/ h).
            Console.WriteLine("Nhập Thời gian (giờ):");
            float hours = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập quãng đường (km):");
            float km = float.Parse(Console.ReadLine());
            float speed_km_h = km / hours;
            float speed_miles_h = speed_km_h * 0.621371f;
            Console.WriteLine($"Speed in km/h: {speed_km_h}");
            Console.WriteLine($"Speed in miles/h: {speed_miles_h}");
        }
        static void Bai_04()
        { ///Write a C# Sharp program that takes the radius of a sphere as input  calculates and displays the surface and volume of the sphere. V  4 / 3 * π * r3
            Console.WriteLine("Nhập bán kính hình cầu:");
            float r = float.Parse(Console.ReadLine());
            float surface = 4 * (float)Math.PI * r * r;
            float volume = (4f / 3f) * (float)Math.PI * r * r;
            Console.WriteLine($"Diện tích hình cầu là : {surface}");
            Console.WriteLine($"Thể tích hình cầu là : {volume}");
        }
        static void Bai_05()
        {
            //Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
            Console.WriteLine("Nhập MỘT kí tự bất kỳ:");
            string? input = Console.ReadLine();
            char c = input[0];
            char vowel = char.ToLower(c);
            char[] Vowels = { 'u', 'e', 'o', 'a', 'i' };
            if (string.IsNullOrEmpty(input) || input.Length != 1)
            {
                Console.WriteLine("Chỉ nhập MỘT kí tự!!");
            }
            else if (char.IsDigit(c))
            {
                Console.WriteLine($"{c} là một chữ số");
            }
            else if (Vowels.Contains(vowel))
            {
                Console.WriteLine($"{c} là một nguyên âm");
            }
            else
            {
                Console.WriteLine($"{c} là một ký tự khác");
            }
        }
        static void Bai_06()
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



        private static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            





        }
    }

}

