using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenNgocPhuongUyen_31231023277_24C1INF50900503
{
    internal class Session06
    {
        // Exercise 1
        /// <summary>
        /// Declare an array N items. With N is entered from user.
        /// 1. Enter item values for this array
        /// 2. Print the array to screen
        /// 3. Write a function that increase each item of the array by adding it with 2
        /// 4. Print the array to screen (again)
        /// </summary>
       
        
        // Cách 1
        /* public static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu N cua mang: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            Console.Write("Nhap gia tri cac phan tu cua mang: \n");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phan tu {i+1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Mang ban dau la: ");
            foreach (int item in a)
            {
                Console.Write(item + ", " );
            }

            IncrementArrayBy2(a);
            Console.Write("\nMang sau khi tang moi phan tu len 2: ");
            foreach(int item in a)
            {
                Console.Write(item + ", ");
            }    
        }
        public static void IncrementArrayBy2(int[]a)
        {
            for (int i = 0;i < a.Length;i++)
            {
                a[i] += 2;
            }    
        } */

        // Cách thầy giải
        public static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine()); 
            int[]a=new int[n];
            // nhập(a);
            generateRandomArray(a);
            InMang(a); Console.WriteLine();

            Console.WriteLine("Nhap so can tim kiem: ");
            int soCanTim = int.Parse(Console.ReadLine());
            int pos = timkiem_linear(a, soCanTim);
            if (pos == -1)
                Console.WriteLine($"SO {soCanTim} khong ton tai trong mang");
            else
                Console.WriteLine($"SO {soCanTim} xuat hien tai vi tri {pos}");
        }

        static void nhap(int[]a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Nhap phan tu {i}: ");
                int v = int.Parse(Console.ReadLine());
                a[i] = v;
            }    
        }

        static void generateRandomArray(int []a)
        {
            Random rnd = new Random();
            for (int i=0;i<a.Length;i++)
            {
                a[i] = rnd.Next(0, 100);    
            }    
        }
        static void InMang(int[] a)
        {
            foreach (int i in a)
            {
                Console.Write($"{i} ");
            }    
        }

        static int timkiem_linear(int[] a, int soCanTim)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == soCanTim)
                    return i;
            }    
            return -1;
        }
    }
}
