using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenNgocPhuongUyen_31231023277_24C1INF50900503
{/// <summary>
 /// Two-Dimensional Arrays exercise: Create a program with following functions
 /// 1. Create an integer matrix N x M (N,M was prompted from user) randomly
 /// 2. Print the matrix.
 /// 3. Print the ith row/column. (i was prompted from user)
 /// 4. Find the max value of the matrix
 /// 5. Find the min value of ith row/col of the matrix.
 /// 6. Transpose the matrix.
 /// 7. Print the main/secondary diagonal values of the matrix.
 /// </summary>
    internal class Session07_page26
    {
        static void Main(string[] args)
        {
            //1.Create an integer matrix N x M(N, M was prompted from user) randomly
            int[,] a;
            Console.Write("Nhap so dong: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int cols = int.Parse(Console.ReadLine());
            a = new int[rows, cols]; //tạo mảng 2 chiều
            //2. Print the matrix.
            NhapMangNgauNhien(a, rows, cols);
            XuatMang(a);

           //3. Print the ith row/ column
            Console.Write("\n3. Ban muon in ra hang hay cot? (h/c): ");
            string choice = Console.ReadLine().ToLower();

            Console.Write("Nhap vi tri index: ");
            int index = int.Parse(Console.ReadLine());

            if (choice == "h")
                PrintRow(a, index);
            else if (choice == "c")
                PrintColumn(a, index);
            else
                Console.WriteLine("Nhap khong hop le. Vui long nhap 'h' cho hang, 'c' cho cot");

            // 4. Find the max value of the matrix
            int maxValue = FindMax(a);
            Console.WriteLine($"\n4. GTLN cua ma tran la: {maxValue}");

            // 5. Find the min value of ith row/column
            Console.Write("\n5. Ban muon tim GTNN tai hang hay cot (hang/cot): ");
            choice = Console.ReadLine().ToLower();
            Console.Write("Nhap vi tri index can tim GTNN: ");
            index = int.Parse(Console.ReadLine());
            int minValue = choice == "hang" ? FindMinRow(a, index) : FindMinColumn(a, index);
            Console.WriteLine($"GTNN tai {choice} {index} la: {minValue}");

            // 6. Transpose the matrix
            Console.WriteLine("\n6. Ma tran chuyen vi la:");
            int[,] transposedMatrix = TransposeMatrix(a);
            XuatMang(transposedMatrix);

            // 7. Print the main/secondary diagonal values
            if (rows == cols)
            {
                Console.WriteLine("\n7. Duong cheo chinh la:");
                PrintMainDiagonal(a);

                Console.WriteLine("Duong cheo phu la:");
                PrintSecondaryDiagonal(a);
            }
            else
            {
                Console.WriteLine("\n7.Duong cheo chi ton tai trong ma tran vuong (hang = cot).");
            }
        }

            static void NhapMangNgauNhien(int[,] a, int rows, int cols)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        Random rnd = new Random();
                        a[i, j] = rnd.Next(1, 100);
                    }
                }
            }
            static void XuatMang(int[,] a)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                       Console.Write(a[i, j] + "\t");
                    }
                Console.WriteLine(); //xuống hàng
                }
            }

            static void PrintRow(int[,] a, int rowIndex)
            {
                int cols = a.GetLength(1);
                for (int j = 0; j < cols; j++)
                    Console.Write(a[rowIndex, j] + "\t");
                Console.WriteLine();
            }

            static void PrintColumn(int[,] a, int colIndex)
            {
                int rows = a.GetLength(0);
                for (int i = 0; i < rows; i++)
                    Console.WriteLine(a[i, colIndex]);
                Console.WriteLine();
            }

            static int FindMax(int[,] a)
            {
                int max = a[0, 0];

                foreach (int value in a)
                    if (value > max)
                        max = value;

                return max;
            }

            static int FindMinRow(int[,] a, int rowIndex)
            {
                int cols = a.GetLength(1);
                int min = a[rowIndex, 0];

                for (int j = 1; j < cols; j++)
                    if (a[rowIndex, j] < min)
                        min = a[rowIndex, j];

                return min;
            }

            static int FindMinColumn(int[,] a, int colIndex)
            {
                int rows = a.GetLength(0);
                int min = a[0, colIndex];

                for (int i = 1; i < rows; i++)
                    if (a[i, colIndex] < min)
                        min = a[i, colIndex];

                return min;
            }

            static int[,] TransposeMatrix(int[,] a)
            {
                int rows = a.GetLength(0);
                int cols = a.GetLength(1);

                int[,] transposed = new int[cols, rows];

                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        transposed[j, i] = a[i, j];

                return transposed;
            }

            static void PrintMainDiagonal(int[,] a)
            {
                int n = a.GetLength(0);
                for (int i = 0; i < n; i++)
                    Console.Write(a[i, i] + " ");
                Console.WriteLine();
            }

            static void PrintSecondaryDiagonal(int[,] a)
            {
                int n = a.GetLength(0);
                for (int i = 0; i < n; i++)
                    Console.Write(a[i, n - i - 1] + " ");
                Console.WriteLine();
            }
      
    }
}

