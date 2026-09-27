using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT_UEH.session_7
{
    internal class excercises
    {
        //Create a random integer values array, then create functions that:
        //1. to calculate the average value of array elements.
        static float average(int[] a)
        {
            int sum = 0;
            float avg = 0;
            foreach (var item in a)
            {
                sum += item;

            }
                avg = (float)sum / a.Length;
            return avg;
        }
        //2. to test if an array contains a specific value.
        static bool test(int[] a, int x)
        {
            
            foreach (var item in a)
            {
                if (item == x)
                    return true;
            }
                return false;
        }
        //3. to find the index of an array element.
        static int FindIndex(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x) return i;
            }
                return -1;
        }
        //4.to remove a specific element from an array.
        static int[] RemoveElement(int[]a, int x)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != x)
                {
                    count++;
                }
            }
            int j = 0;
            int[] b = new int[count];
            for (int i=0; i<a.Length; i++)
                {
                    if (a[i] != x)
                    {
                        b[j] = a[i];
                        j++;
                    }
                }
                       
            
            return b;
        }
        //5.to find the maximum and minimum value of an array.
        static (int Min,int Max) MinMax(int[] a)
        {
            int Min= a[0];
            int Max = a[0];
            for (int i=0; i<a.Length; i++)
            {
                if (a[i]> Max)
                {
                    Max = a[i];
                }
                else if (a[i] < Min)
                {
                    Min = a[i];
                }
            }
            return (Min,Max);
            

        }
        //6.to reverse an array of integer values.
        static int[] reverse(int[] a )
        {
            //Array.Reverse(a); //cách 1:Dùng Reverse
            //return a;

            int[] res = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                res[i] = a[a.Length - 1 - i];
            return res;
        }
        //7.to find duplicate values in an array of values.
        static List<int> DupValues(int[] a)
        {
            List<int> res = new List<int>();
            for (int i= 0; i< a.Length; i++)
            {
                for (int j=i+1; j< a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        if (!res.Contains(a[i]))
                        {
                            res.Add(a[i]);
                        }
                    }
                }
            }
            return res;
        }
        //8.to remove duplicate elements from an array.
        static List<int> RemoveDup(int[] a)
        {
            List<int> res = new List<int>();
            for (int i=0; i< a.Length; i++)
            {
                if (!res.Contains(a[i]))
                {
                    res.Add(a[i]);
                }
            }
            return res;
        }

        //requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
        static void BubbleSort(int[]a)
        {
            for (int i=0; i< a.Length -1; i++)
            {
                for (int j= 0; j< a.Length-1-i; j++)
                {
                    if (a[j] > a[j+1])
                    {
                        int temp = a[j];
                        a[j] = a[j+1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        
        //-Request a sentence from the user, then ask to enter a word.Search if the word appears in the phrase using the linear search algorithm.
        static bool Search(string a, string x)
        {
            string[] str = a.ToLower().Split(' ');
            foreach ( var i in str )
            {
                if (i==x)
                {
                    return true;
                }
            }
            return false;
        }
        //Create an integer matrix N x M (N,M was prompted from user) randomly.
        static int[,] matrix(int n,int m)
        {
            int[,] matrix = new int[n, m];
            Random rnd = new Random();
            for (int i=0; i<n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(0,500);
                }
            }
            return matrix;
        }
        //In ra dòng thứ i và cột thứ j
        static int[] inDong(int[,] matrix, int i)
        {
            int soDong = matrix.GetLength(0);
            int soCot = matrix.GetLength(1);

            if (i < 0 || i >= soDong)
            {
                return null;
            } 
        
            int[] dong = new int[soCot];
            for (int j=0; j<soCot; j++)
            {
                dong[j] = matrix[i, j];
            }
            return dong;
        }
        static int[] inCot(int[,] matrix, int i)
        {
            int soDong = matrix.GetLength(0);
            int soCot = matrix.GetLength(1);
            if (i < 0 || i >= soCot) return null;
            int[] cot = new int[soDong];
            for (int j= 0; j< soDong; j++)
            {
                cot[j] = matrix[j,i];
            }
            return cot;

        }
        //Find the max value of the matrix.
        static int max(int[,] matrix)
        {
            int max = matrix[0,0];
            for (int i=0; i<matrix.GetLength(0);i++)
            {
                for (int j= 0; j< matrix.GetLength(1);j++)
                {
                    if (matrix[i,j]>max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }
        //Find the min value of ith row/col of the matrix.
        static int minDong(int[,] matrix, int i)
        {
            
            int min = matrix[i, 0];
            
            for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                if (min > matrix[i,j])
                {
                    min = matrix[i,j];
                }
            }
            return min;
        }
        static int minCot(int[,] matrix, int i)
        {
            int min = matrix[0,i];
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if(min> matrix[j,i])
                {
                    min = matrix[j, i];
                }
            }
            return min;
        }
        // In ma trận:
        static void InMatran(int[,] matrix)
        {
            for (int i= 0; i< matrix.GetLength(0); i++)
            {
                for(int j=0; j< matrix.GetLength(1);j++)
                {
                    Console.Write(matrix[i,j]+ "\t");
                }
                Console.WriteLine();
            }
        }
        //Transpose the matrix.
        static int[,] Transpose(int[,] matrix)
        {
            int[,] trans = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for(int i=0; i< matrix.GetLength(0); i++)
            {
                for (int j=0; j< matrix.GetLength(1); j++)
                {
                    trans[j, i]= matrix[i,j];
                }
            }
            return trans;
        }
        //Print the main/secondary diagonal values of the matrix.(square maxtrix)
        static void InDCC(int[,] matrix)
        {
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix.GetLength(0) == matrix.GetLength(1))
                {
                    Console.Write(matrix[i, i] + "\t");
                }
            }
        }
        static void InDCP(int[,] matrix)
        {
            for (int i=0; i< matrix.GetLength(0); i++)
            {
                for (int j =0; j < matrix.GetLength(1); j++)
                {
                    if (i+ j == matrix.GetLength(1)-1)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số dòng a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột b: ");
            int b = int.Parse(Console.ReadLine());
            int[,] Matran = matrix(a, b);
            int soDong = Matran.GetLength(0);
            int soCot = Matran.GetLength(1);

            for (int i=0; i<a;i++)
            {
                for (int j=0; j<b; j++)
                {
                    Console.Write(Matran[i,j] +"\t");
                }
                Console.WriteLine();
            }
            Console.Write("Nhập số dòng muốn in các phần tử: ");
            int sd = int.Parse(Console.ReadLine());
            int[] row = inDong(Matran, sd-1);
            Console.WriteLine(string.Join(" ",row));
            Console.Write("Nhập số cột muốn in các phần tử: ");
            int sc = int.Parse(Console.ReadLine());
            int[] col = inCot(Matran, sc-1);
            Console.WriteLine(string.Join(" ", col));
            Console.WriteLine("Giá trị lớn nhất trong ma trận là:");
            Console.WriteLine(max(Matran));

            Console.Write("Nhập số dòng muốn tìm min: ");
            int sodong = int.Parse(Console.ReadLine());
            int kq= minDong(Matran, sodong-1);
            Console.WriteLine($"Min của dòng {sodong} là: {kq}");

            Console.Write("Nhập số cột muốn tìm min: ");
            int socot = int.Parse(Console.ReadLine());
            int ketqua = minCot(Matran, socot - 1);
            Console.WriteLine($"Min của cột {socot} là: {ketqua}");

            int[,] chuyenVi = Transpose(Matran);
            Console.WriteLine($"Ma trận chuyển vị là:");
            InMatran(chuyenVi);

            Console.WriteLine("Đường chéo chính là:");
            InDCC(Matran);
            Console.WriteLine();
            Console.WriteLine("Đường chéo phụ là:");
            InDCP(Matran);
        }
    }
            //int[] n = { 21, 7, 5, 7, 5 ,21 };
            //Console.WriteLine("Nhập số phần tử trong mảng:");
            //int[] TB = new int[int.Parse(Console.ReadLine())];
            //Random rnd = new Random(); 
            //Console.WriteLine( average( n));

            //Console.WriteLine(test(n, 21));

            //int[] res = RemoveElement(n, 21);
            //Console.WriteLine(string.Join(",", res));

            //Console.WriteLine(MinMax(n));

            //int[] res = reverse(n);
            //Console.WriteLine(string.Join(" ", res));

            //Console.WriteLine(string.Join(",",DupValues(n)));

            //Console.WriteLine(string.Join(" ",RemoveDup(n)));

            //int[] x = new int[10];
            //for (int i= 0; i<10; i++)
            //{
            //    Console.WriteLine($"Nhập số thứ:{i+1}");
            //    x[i] = int.Parse(Console.ReadLine());
            //}
            //BubbleSort(x);
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(x[i] + " ");
            //}

            //Console.WriteLine("Nhập câu:");
            //string a = Console.ReadLine();
            //Console.WriteLine("Nhập từ muốn tìm:");
            //string x = Console.ReadLine().ToLower();
            //bool res = Search(a, x);
            //Console.WriteLine(res);
}
