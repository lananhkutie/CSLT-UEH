using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT_UEH.session_7
{
    internal class String
    {
        /// <summary>
        /// Write a program in C# Sharp
        /// </summary>
        /// <param name="args"></param>
        static bool CompareStrings(string str1, string str2)
        {
            int count1 = 0, count2 = 0;
            foreach (char c in str1)
            {
                count1++;
            }
            foreach (char c in str2)
            {
                count2++;
            }
            for (int j=0; j < count1 && j < count2; j++)
            {
                if (str1[j] != str2[j])
                {
                    return false;
                }
            }
            return true;


        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //-to input a string and print it.
            Console.WriteLine("Nhập vào chuỗi thứ 1 (str1):");
            string str1 = Console.ReadLine();
            Console.WriteLine(str1);
            //-to find the length of a string without using a library function.
            int length = 0;
            foreach (char c in str1)
            {
                length++;
            }
            Console.WriteLine("Length of the string: " + length);

            //-to separate individual characters from a string.
            foreach (char c in str1)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
            //-to print individual characters of the string in reverse order.
            string reversed = "";
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(str1[i]);
            }
            //-to count the total number of words in a string.
            int wordcount = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != ' ')
                {
                    wordcount++;
                }
            }
            Console.WriteLine($"Số lượng từ là: {wordcount} ");
            //-to compare two strings without using a string library functions.
            Console.WriteLine("Nhập vào chuỗi thứ 2 (str2):");
            string str2 = Console.ReadLine();
            Console.WriteLine($"Kết quả so sánh 2 chuỗi giống nhau: {CompareStrings(str1, str2)}");
            //-to count the number of alphabets, digits, and special characters in a string.
            int alphabets = 0, digits = 0, specialChars = 0;
            string cleanStr = str2.Replace(" ", "");
            for (int i = 0; i < str2.Length; i++)
            {
                if (char.IsLetter(str2[i]))
                {
                    alphabets++;
                }
                else if (char.IsDigit(str2[i]))
                {
                    digits++;
                }
                else
                {
                    specialChars++;
                }
            }
            Console.WriteLine($"Số lượng chữ cái: {alphabets}");
            Console.WriteLine($"Số lượng chữ số: {digits}");
            Console.WriteLine($"Số lượng ký tự đặc biệt: {specialChars}");
            //-to count the number of vowels or consonants in a string.
            int vowels = 0, consonants = 0;
            string cleanStr2 = str2.ToLower().Replace(" ", "");
            for (int i = 0; i < cleanStr2.Length; i++)
            {
                if (cleanStr2[i] == 'a' || cleanStr2[i] == 'e' || cleanStr2[i] == 'i' || cleanStr2[i] == 'o' || cleanStr2[i] == 'u')
                {
                    vowels++;
                }
                else if (char.IsLetter(cleanStr2[i]))
                {
                    consonants++;
                }
            }
            Console.WriteLine($"Số lượng nguyên âm: {vowels}");
            Console.WriteLine($"Số lượng phụ âm: {consonants}");
            //-to check whether a given substring is present in the given string.
            Console.WriteLine("Nhập vào chuỗi con cần kiểm tra:");
            string substring1 = Console.ReadLine();
            bool isPresent = str2.Contains(substring1);
            Console.WriteLine($"Chuỗi con có xuất hiện trong chuỗi chính: {isPresent}");
            //-to search for the position of a substring within a string.
            Console.WriteLine("Nhập vào chuỗi cần tìm vị trí:");
            string substring2 = Console.ReadLine();
            int pos= str2.IndexOf(substring2);
            Console.WriteLine($"Chuỗi nằm ở vị trí: {pos}");
            //-to check whether a character is an alphabet and not and if so, check for the case.
            Console.WriteLine("Nhập từ cần kiểm tra:");
            string input= Console.ReadLine();
            if (input.Length==1)
            {
                if (char.IsLetter(input[0]))
                {
                    if (char.IsUpper(input[0]))
                    {
                        Console.WriteLine("Đây là chữ cái in hoa");
                    }
                    else
                    {
                        Console.WriteLine("Đây là chữ cái in thường");
                    }
                }
                else
                {
                    Console.WriteLine("Đây không phải là chữ cái");
                }
                //-to find the number of times a substring appears in a given string.
                Console.WriteLine("Nhập vào chuỗi con cần kiểm tra số lần xuất hiện:");
                string substring3 = Console.ReadLine();
                int countSub = 0;
                for (int i = 0; i < cleanStr2.Length; i++)
                {
                    if (cleanStr2.Contains(substring3))
                    {
                        countSub++;
                    }
                }
                    Console.WriteLine($"Số lần xuất hiện của chuỗi con: {countSub}");
                //-to insert a substring before the first occurrence of a string.
                Console.WriteLine("Nhập chuỗi gốc:");
                string chuoiGoc = Console.ReadLine();
                Console.WriteLine("Nhập chuỗi cần tìm:");
                string chuoiCanTim = Console.ReadLine();
                Console.WriteLine("Nhập chuỗi cần chèn:");
                string chuoiCanChen = Console.ReadLine();
                int viTri= chuoiGoc.IndexOf(chuoiCanTim);
                if (viTri==-1)
                {
                    Console.WriteLine("Chuỗi cần tìm không tồn tại trong chuỗi gốc!");
                }
                else
                {
                    chuoiGoc = chuoiGoc.Insert(viTri, chuoiCanChen);
                    Console.WriteLine($"Chuỗi sau khi chèn:  {chuoiGoc}");
                }
            }
        }
    }
}
