using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenNgocPhuongUyen_31231023277_24C1INF50900503
{
    /// <summary>
    /// Exercise02. Create a Jagged Array with random integer numbers (or by user input) by getting the number of rows and columns from the user and printing the data in the array to the user.
    /// Then, create functions to implement following tasks:
    /// 1. Print the biggest number of each row and the largest number of the whole array.
    /// 2. Sort values ascending of each row.
    /// 3. Print items of the array that are prime.
    /// 4. Search and print all positions of a number (enter from the user).
    /// </summary>
    internal class Session07_page32_ex2
    {
        static void Main(string[] args)
        {
            int[][] a;
            Console.Write("Nhap so dong: ");
            int rows = int.Parse(Console.ReadLine());
            a = new int[rows][];
            NhapMangTuDong(a);
            
            // Display the jagged array
            Console.WriteLine("\nThe jagged array:");
            InMang(a);
            
            // 1. Print the biggest number in each row and the largest number in the whole array
            printBiggestNumbers(a);
            
            // 2. Sort each row in ascending order
            SortRowsAscending(a);
            Console.WriteLine("\n2. Ma tran sau khi sap xep theo thu tu tang dan la: ");
            InMang(a);

            // 3. Print all prime numbers in the jagged array
            PrintPrimes(a);
            
            // 4. Search and print all positions of a user-entered number
            Console.Write("\n4. Nhap so can tim vi tri: ");
            int index = int.Parse(Console.ReadLine());
            SearchAndPrintPositions(a, index);
        }


        static void NhapMangTuDong(int[][] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Nhap so cot cho dong {i}: ");
                int cols = int.Parse(Console.ReadLine());
                array[i] = new int[cols]; //cấp phát bộ nhớ tự động
                for (int j = 0; j < cols; j++)
                {
                    array[i][j] = random.Next(100);
                }
            }
        }
        static void InMang(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void printBiggestNumbers(int[][] array)
        {
            int largestInArray = int.MinValue;
            Console.WriteLine("\n1. So lon nhat tren moi hang la:");
            for (int i = 0; i < array.Length; i++)
            {
                int largestInRow = int.MinValue;
                foreach (int num in array[i])
                {
                    if (num > largestInRow)
                        largestInRow = num;
                    if (num > largestInArray)
                        largestInArray = num;
                }
                Console.WriteLine($"Hang {i + 1}: {largestInRow}");
            }
            Console.WriteLine($"\nSo lon nhat trong ma tran la: {largestInArray}");
        }

        static void SortRowsAscending(int[][] array)
        {
            foreach (var row in array)
            {
                Array.Sort(row);
            }
        }

        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static void PrintPrimes(int[][] array)
        {
            Console.WriteLine("\n3. So nguyen to trong ma tran la:");
            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (IsPrime(array[i][j]))
                    {
                        Console.WriteLine($"Hang {i + 1}, Cot {j + 1}: {array[i][j]}");
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("Khong tim thay so nguyen to.");
            }
        }

        static void SearchAndPrintPositions(int[][] array, int index)
        {
            Console.WriteLine($"\nVi tri cua so {index} trong ma tran la:");
            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] == index)
                    {
                        Console.WriteLine($"Hang {i + 1}, Cot {j + 1}");
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine($"{index} khong ton tai trong ma tran.");
            }
        }
    }
}
