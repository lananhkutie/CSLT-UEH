using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT_UEH.session_6
{
    internal class BTVNSlide
    {
        static void Maximum(int input1, int input2, int input3)
        {
            Console.WriteLine("Write a C# function to find the maximum of three numbers.");

            //Cách 1: Sử dụng Math.Max
            //float max = Math.Max(input1, Math.Max(input2, input3));
            //Console.WriteLine($"Số lớn nhất là: {max}");
            //Cách 2: Sử dụng if else
            if ( input1 > input2 && input1>input3)
            {
                Console.WriteLine( "Số lớn nhất là " + input1);
            }
            else if (input2> input1 && input2> input3)
            {
                Console.WriteLine( "Số lớn nhất là " + input2);
            }
            else
            {
                Console.WriteLine( "Số lớn nhất là " + input3);
            }

        }
        static void Calc(int a)
        {
            long kq = 1;
            Console.WriteLine("Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.");
            for ( int i = 1; i<= a; i++)
            {
                kq *=i;
            }
            Console.WriteLine($"Giai thừa của {a} là: {kq}");
        }
        static bool IsPrime (int x)
        {
            if (x < 2) 
                return false;
            for (int i = 2; i <= x/2 ; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
      
            return true;
            
        }
        static void LessThanNPrime(int n)
        {
            int count = 0;
            for (int i = 2; i < n ; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                    Console.Write( i+",");
                }
            }
            Console.WriteLine( "có " + count + " số nguyên tố bé hơn " + n);
        }
        static void FirstNPrime(int n)
        {
            int count = 0;
            for (int i=2; count < n; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                Console.Write( $"{i},");
                }
            }    
            
        }
        static bool PerfectNumber(int n)
        { //Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
            int tong = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    tong += i;
                }
            }
                return tong == n;
            //if (tong == n)
            //{
            //    Console.Write($"{n} là số hoàn thiện");
            //}
            //else
            //{
            //    Console.WriteLine($"{n} không là số hoàn thiện");
            //}

        }
        static void PerfectNumberLessThan(int n)
        {
            for (int i =1; i< n; i++)
            {
                if (PerfectNumber(i))
                {
                    Console.Write( i +",");
                } 

            }
        }
        static void Pangram(string str)
        {
        //Write a C# function to check whether a given string is a pangram or not.
        //A pangram is a sentence that uses every letter of the alphabet at least once.

        }
        public static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Maximum(5, 10, 3);
            //Calc(3);
            //IsPrime(7);
            //FirstNPrime(10);
            //PerfectNumber(496);
            //PerfectNumberLessThan(100000);

        }
    }
}
