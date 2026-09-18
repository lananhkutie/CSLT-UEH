using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Text;

namespace CSLT_UEH._20_bài_fuctions
{
    internal class excercises
    {
        //Bài 1: Tính tổng hai số nguyên
        static int Sum(int a, int b)
        {
            return a + b;
        }
        //Bài 2: Kiểm tra số chẵn lẻ 
        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
        //Bài 3: Tìm số lớn nhất trong ba số
        static int TimMax(int a, int b, int c)
        {
            if (a > b && a > c)
                return a;
            else if (b > a && b > c)
                return b;
            else
                return c;

        }
        //Bài 4: Tính giai thừa của một số 
        static long GiaiThua(int n)
        {
            long gth = 1;
            for (int i = 1; i <= n; i++)
            {
                gth *= i;
            }
            return gth;
        }
        //Bài 5: Đảo ngược chuỗi ký tự 
        static string DaoNguocChuoi(string str)
        {
            char[] sentence = str.ToCharArray();
            Array.Reverse(sentence);
            return new string(sentence);
        }
        //Bài 6: Kiểm tra số nguyên tố 
        static bool IsPrime(int n)
        {
            bool x = true;
            if (n < 2) return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    x = false;
                    break;
                }
            }
            return x;
        }
        //Bài 7: In dãy Fibonacci
        static void Fibonacci(int n)
        {
            if (n <= 0) return;
            int f1 = 0, f2 = 1, f3 = 0;
            for (int i = 0; i < n; i++)
            {
                f3 = f1 + f2;
                Console.Write(f1 + ",");
                f1 = f2;
                f2 = f3;
            }

        }
        //Bài 8: Đếm số lượng nguyên âm trong chuỗi
        static int NguyenAm(string str)
        {
            int count = 0;
            foreach (char c in str.ToLower())
            {
                if ("ueoai".Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
        //Bài 9: Tính lũy thừa 
        static double LuyThua(double x, int y)
        {
            double luythua = 1;
            for (int i = 0; i < y; i++)
            {
                luythua *= x;
            }
            return luythua;
        }
        //Bài 10: Tính điểm trung bình của mảng
        static double TinhTB(int[] arr)
        {
            double avg = 0;
            int sum = 0;
            foreach (int i in arr)

            {
                sum += i;
                avg = sum / arr.Length;
            }
            return avg;
        }
        //Bài 11: Kiểm tra chuỗi đối xứng (Palindrome) 
        static bool Palindrome(string str)
        {
            string pal = DaoNguocChuoi(str);
            if (pal == str)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Bài 12: Chuyển đổi nhiệt độ
        static double CelciusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }
        //Bài 13: Tìm giá trị nhỏ nhất trong mảng
        static int TimMin(int[] min)
        {
            int Min = min[0];
            for (int i = 0; i < min.Length; i++)
            {
                if (min[i] < Min)
                {
                    Min = min[i];
                }

            }
            return Min;
        }
        //Bài 14: Tính tổng các chữ số của một số nguyên 
        static int TongChuSo(int n)
        {
            n = Math.Abs(n);
            int tong = 0;
            while (n > 0)
            {
                tong += n % 10;
                n /= 10;
            }
            return tong;
        }

        //Bài 15: Sắp xếp mảng tăng dần 
        static void SapxepMang(int[] arr)
        {
            {
                Array.Sort(arr);
                //for (int i = 0; i < arr.Length; i++)
                //{
                //    Console.Write(arr[i]);
                //    if (i < arr.Length - 1)
                //        Console.Write(" ");
                //}
                Console.WriteLine();
            }

        }
        //Bài 16: Xóa ký tự trùng lặp
        static string XoaTrungLap(string s)
        {
            string clean = s.ToLower();
            string chuoi="";
            for (int i =0; i< clean.Length; i++)
            {
                char c = clean[i];
                if (chuoi.Contains(c))
                {
                    continue;
                }
                else
                chuoi += c.ToString();
            }
            return chuoi;
        }
        //Bài 17: Tìm ước chung lớn nhất (UCLN)
        static int UCLN(int a, int b)
        {
            {
                while (b != 0)
                {
                    int soDu = a%b;
                    a = b;
                    b = soDu;
                }
            }   
            return a;
        }
        //Bài 18: Chuyển đổi hệ thập phân sang nhị phân
        static string DecimalToBinary(int n)
        {
            if (n == 0) return "0";
            else 
            {
                int mod = 0;
                string bin = "";
                while (n != 0)
                {
                    mod = n % 2;
                    bin = mod.ToString() + bin;
                    n = n / 2;
                }
                return bin;
            }
        }
        //Bài 19: Kiểm tra năm nhuận
        static bool KtNamNhuan(int n)
        {
            bool NamNhuan;
            if (n % 4 == 0 && n % 100 != 0 || n % 400 == 0) return true;
            else return false;
        }
        //Bài 20: Đếm số từ trong câu 
        static int DemTu(string sentence)
        {
            string[] words = sentence.Split(" ");
            return words.Length;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine( XoaTrungLap("Supercalifrasgilisticexpialidouciou"));
            //Console.WriteLine( UCLN(12,18));
            //Console.WriteLine( DecimalToBinary(10));
            //Console.WriteLine( KtNamNhuan(2000));
            Console.WriteLine( DemTu(" góc phố này nơi mình quen nhau"));
        }

    }
}
