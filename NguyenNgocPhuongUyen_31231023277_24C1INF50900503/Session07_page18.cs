using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace NguyenNgocPhuongUyen_31231023277_24C1INF50900503
{
    /// <summary>
    /// Page 18: Create a random integer values array, then create functions that:
    /// 1. to calculate the average value of array elements.
    /// 2. to test if an array contains a specific value.
    /// 3. to find the index of an array element.
    /// 4. to remove a specific element from an array.
    /// 5. to find the maximum and minimum value of an array.
    /// 6. to reverse an array of integer values.
    /// 7. to find duplicate values in an array of values.
    /// 8. to remove duplicate elements from an array.
    /// </summary>
    internal class Session07_page18
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101); // phần tử mảng có giá trị ngẫu nhiên từ 1 đến 100
            }

                Console.WriteLine("Mang gia tri ngau nhien la:");
                PrintArray(array);

                // 1. Calculate the average value of array elements
                Console.WriteLine($"\n1. Trung binh cong gia tri cac phan tu cua mang la: {CalculateAverage(array)}");

                // 2. Test if the array contains a specific value
                Console.Write("\n2. Nhap 1 phan tu de kiem tra: ");
                int valueToCheck = int.Parse(Console.ReadLine());
                Console.WriteLine($"Mang co ton tai {valueToCheck}: {ArrayContainsValue(array, valueToCheck)}");

                // 3. Find the index of an array element
                Console.Write("\n3. Nhap gia tri can tim index: ");
                int valueToFind = int.Parse(Console.ReadLine());
                Console.WriteLine($"{valueToFind} co index la: {GetIndex(array, valueToFind)}");

                // 4. Remove a specific element from the array
                Console.Write("\n4. Nhap 1 phan tu can xoa khoi mang: ");
                int valueToRemove = int.Parse(Console.ReadLine());
                array = RemoveValue(array, valueToRemove);
                Console.WriteLine($"Mang sau khi da xoa phan tu {valueToRemove} la: ");
                PrintArray(array);

                // 5. Find the maximum and minimum values of the array
                Console.WriteLine($"\n5. GTLN cua mang la: {FindMax(array)} \nGTNN cua mang la: {FindMin(array)}");

                // 6. Reverse the array
                int[] reversedArray = ReverseArray(array);
                Console.Write("\n6. Mang dao nguoc la:");
                PrintArray(reversedArray);

                // 7. Find duplicate values in the array
                Console.Write("\n7. Cac gia tri trung lap trong mang la: ");
                var duplicates = GetDuplicates(array);
                if (duplicates.Any())
                {
                    Console.WriteLine(string.Join(", ", duplicates));
                }
                else
                {
                    Console.WriteLine("Khong tim thay gia tri trung lap.");
                }

                // 8. Remove duplicate elements from the array
                array = RemoveDuplicates(array);
                Console.WriteLine("\nMang sau khi xoa các gia tri trung lap la: ");
                PrintArray(array);
        }

            static void PrintArray(int[] array)
            {
                Console.WriteLine(string.Join(" ", array));
            }

            // 1. Calculate the average value of array elements
            static double CalculateAverage(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return (double)sum / array.Length;
            }

            // 2. Test if the array contains a specific value
            static bool ArrayContainsValue(int[] array, int value)
            {
                foreach (var num in array)
                {
                    if (num == value)
                    {
                        return true;
                    }
                }
                return false;
            }

            // 3. Find the index of an array element
            static int GetIndex(int[] array, int value)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == value)
                    {
                        return i;
                    }
                }
                return -1; // không tìm thấy thì trả kết quả là -1
            }

            // 4. Remove a specific element from the array
            static int[] RemoveValue(int[] array, int value)
            {
                List<int> result = new List<int>();
                foreach (var num in array)
                {
                    if (num != value)
                    {
                        result.Add(num);
                    }
                }
                return result.ToArray();
            }

            // 5. Find the maximum value of the array
            static int FindMax(int[] array)
            {
                int max = int.MinValue;
                foreach (var num in array)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
                return max;
            }

            // 5. Find the minimum value of the array
            static int FindMin(int[] array)
            {
                int min = int.MaxValue;
                foreach (var num in array)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
                return min;
            }

            // 6. Reverse the array
            static int[] ReverseArray(int[] array)
            {
                int[] reversed = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    reversed[i] = array[array.Length - 1 - i];
                }
                return reversed;
            }

            // 7. Find duplicate values in the array
            static List<int> GetDuplicates(int[] array)
            {
                Dictionary<int, int> counts = new Dictionary<int, int>();
                foreach (var num in array)
                {
                    if (counts.ContainsKey(num))
                    {
                        counts[num]++;
                    }
                    else
                    {
                        counts[num] = 1;
                    }
                }
                List<int> duplicates = new List<int>();
                foreach (var kvp in counts)
                {
                    if (kvp.Value > 1)
                    {
                        duplicates.Add(kvp.Key);
                    }
                }
                return duplicates;
            }

            // 8. Remove duplicate elements from the array
            static int[] RemoveDuplicates(int[] array)
            {
                HashSet<int> unique = new HashSet<int>();
                foreach (var num in array)
                {
                    unique.Add(num);
                }
                return unique.ToArray();
            }
        }
    }
