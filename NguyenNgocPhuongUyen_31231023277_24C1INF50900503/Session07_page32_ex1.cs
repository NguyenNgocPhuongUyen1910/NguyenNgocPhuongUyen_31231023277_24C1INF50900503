using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NguyenNgocPhuongUyen_31231023277_24C1INF50900503
{
    /// <summary>
    /// Jagged Array - Exercise 1
    /// 1. Create a jagged array and initialize it using the following values for its rows and columns;
    /// Then, display it.
    /// 1 1 1 1 1
    /// 2 2
    /// 3 3 3 3
    /// 4 4
    /// </summary>
    internal class Session07_page32_ex1
    {
        static void Main(string[] args)
        {
            // Tạo 1 jagged array
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[] { 1, 1, 1, 1, 1 };
            jaggedArray[1] = new int[] { 2, 2 };
            jaggedArray[2] = new int[] { 3, 3, 3, 3 };
            jaggedArray[3] = new int[] { 4, 4 };

            // In mảng
            Console.WriteLine("Jagged Array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine(); //xuống hàng
            }
        }
    }
}
