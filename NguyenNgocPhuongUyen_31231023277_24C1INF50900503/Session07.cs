using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NguyenNgocPhuongUyen_31231023277_24C1INF50900503
{
    internal class Session07
    {

        public static void Main(string[] args)
        {
            int[,] a;
            Console.Write("Nhap so dong: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int cols = int.Parse(Console.ReadLine());
            //tạo mảng 2 chiều
            a = new int[rows, cols];
            //NhapMangBangCom(a, rows, cols); //TH xuất ra ma trận do người dùng nhập
            NhapMangNgauNhien(a, rows, cols); //TH xuất ra ma trận ngẫu nhiên
            //XuatMang(a);

            Console.WriteLine();
            Console.Write("Nhap so can tim: ");
            int val = int.Parse(Console.ReadLine());
            SearchLinear(a, val);

            Console.WriteLine();
            Console.Write("Do you want to print a row or a column? (r/c): "); // 2. in ra một dòng, hoặc 1 hàng từ ma trận
            string choice = Console.ReadLine().ToLower();
            Console.Write("Enter the index of row or column to print (0-based): ");
            int index = int.Parse(Console.ReadLine());
            if (choice == "r")
            {
                PrintRow(a, index);
            }
            else if (choice == "c")
            {
                PrintColumn(a, index);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'r' for row or 'c' for column.");
            }
        }


        static void NhapMangBangCom(int[,] a, int rows, int columns) // TH người dùng tự nhập mảng
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine()); //phần tử được người dùng nhập vào
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

        static void NhapMangNgauNhien(int[,] a, int rows, int cols) // TH mảng được tạo ngẫu nhiên
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Random rnd = new Random();
                    a[i, j] = rnd.Next(1, 100);
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void SearchLinear(int[,] a, int value) // Tìm kiếm 1 số xuất hiện ở vị trí nào
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == value)
                    {
                        Console.WriteLine($"{value} xuat hien tai dong {i} cot {j}\n");
                    }
                }
            }
        }

        static void PrintRow(int[,] a, int row) // in 1 hàng
        {
            int cols = a.GetLength(1);
            if (row >= 0 && row < a.GetLength(0))
            {
                Console.Write("Row " + row + ": ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(a[row, j] + "\t");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid row index.");
            }
        }
        static void PrintColumn(int[,] a, int col) // in 1 cột
        {
            int rows = a.GetLength(0);
            if (col >= 0 && col < a.GetLength(1))
            {
                Console.WriteLine("Column " + col + ": ");
                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine(a[i, col] + "\t");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid row index.");
            }
        }

        /*
        public static void Main()
        {
            int[][] a;
            Console.Write("Nhap so dong: ");
            int rows = int.Parse(Console.ReadLine());
            a = new int[rows][];
            NhapMangTuDong(a);
            InMang(a);

            Console.WriteLine();
            Console.Write("\nDo you want to print a row or a column? (r/c): "); // 2. in ra một dòng, hoặc 1 hàng từ ma trận
            string choice = Console.ReadLine().ToLower();
            Console.Write("Enter the index of row or column to print (0-based): ");
            int index = int.Parse(Console.ReadLine());
            if (choice == "r")
            {
                PrintRow(a, index);
            }
            else if (choice == "c")
            {
                PrintColumn(a, index);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'r' for row or 'c' for column.");
            }

        }

        static void NhapMangTuDong(int[][] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap so cot cho dong {i}: ");
                int cols = int.Parse(Console.ReadLine());
                a[i] = new int[cols]; //cấp phát bộ nhớ tự động
                for (int j = 0; j < cols; j++)
                {
                    a[i][j] = random.Next(100); //nhập số tự động
                    //Console.WriteLine($"a[{i}][{j}] = "); //người dùng tự nhập
                    //a[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void InMang(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine();
            }
        }  */
    }
}