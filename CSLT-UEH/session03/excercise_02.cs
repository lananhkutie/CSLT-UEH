using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CSLT_UEH.session02
{
    internal class Exercises_02
    {
        static void bai1()
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
        private static void Main(string[] args)
        {
            bai1 ();
        }
    }
}
