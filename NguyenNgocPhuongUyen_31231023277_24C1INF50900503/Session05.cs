using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NguyenNgocPhuongUyen_31231023277_24C1INF50900503
{
    internal class Session05
    {
        static void Main(string[] args)
        {
            /* int m = maxOfThereNumber(7, 5, 4);
            Console.WriteLine($"Max = {m}"); */ //ex01

            //factorial(5); //ex02

            //isPrime(10); //ex03

            //printPrimeNumberUnderN(100); //ex04.1

            //printFirstNPrime(100); //ex04.2

            /* isPerfectNumber(7); //ex05
            perfectNumberLessThan1000(1000); */

            checkPangram(0); //ex06

        }

        /// <summary>
        /// 1. Write a C# function to find the maximum of three numbers. - Improve the next version that accept at least 1 parameter
        /// </summary>
        static int maxOfThereNumber(int a, int b, int c)
        {
            //return Math.Max(Math.Max(a, b), c);
            int max = 0;
            if (a>b && a>c)
                max = a;
            else if (b>c && b>a) max = b;
            else
                max = c;
            return max;
        }

        /// <summary>
        /// 2. Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
        /// </summary>
        static void factorial(int x) //ex02
        {
            int gt = 1;
            for (int i = 1; i <= x; i++)
            {
                gt = gt * i;
            }
            Console.WriteLine($"Factorial of {x} is {gt}");
        }
        /// <summary>
        /// 3. Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
        /// </summary>

        static bool isPrime(int number) //ex03
        {
            if (number < 2) return false;
            for (int i = 2; i <= number / 2; i++)
                if (number % i == 0)
                {
                    Console.WriteLine($"{number} khong la so nguyen to");
                    return false;
                }
            Console.WriteLine($"{number} la so nguyen to");
            return true;
        }

        /// <summary>
        /// 4. Write a C# function to print
        /// 4.1 all prime numbers that less than a number(enter prompt keyboard).
        /// 4.2 the first N prime numbers
        /// </summary>

        static bool aisPrime(int number) //ex04
        {
            if (number < 2) return false;
            for (int i = 2; i <= number / 2; i++)
                if (number % i == 0)
                    return false;
            return true;
        }
        static void printPrimeNumberUnderN(int n) //ex04.1
        {
            for(int i=2; i<=n; i++)
                if(aisPrime(i))
                    Console.WriteLine(i);
        }

        static void printFirstNPrime(int n) //ex04.2
        {
            int so = 2;
            int dem = 0;
            while (dem<n)
            {
                if (aisPrime(so))
                {
                    Console.Write(so + ", ");
                    dem++;
                }
                so++;
            }    
        }

        /// <summary>
        /// 5. Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
        /// </summary>
        static bool isPerfectNumber(int number) //ex05.1
        {
            int demUoc = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    demUoc += i;
            }
            if (demUoc == number)
            {
                Console.WriteLine($"{number} is perfect number");
                return true;
            }
            Console.WriteLine($"{number} is not perfect number");
            return false;
        }

        static bool nisPerfectNumber(int number) //ex05.2
        {
            int demUoc = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    demUoc += i;
            }
            if (demUoc == number)
                return true;
            return false;
        }

        static void perfectNumberLessThan1000(int n)
        {
            Console.Write("Perfect numbers less than 1000: ");
            for (int i = 1; i < n; i++)
            {
                if (nisPerfectNumber(i))
                {
                    Console.Write(i+" ");
                }
            }
        }

        /// <summary>
        /// 6. Write a C# function to check whether a string is a pangram or not
        /// (Note : Pangrams are words or sentences containing every letter of the alphabet at least once.For example : "The quick brown fox jumps over the lazy dog")
        /// </summary>
        static bool IsPangram(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                return false;
            }

            // Create a boolean array to track the presence of each letter
            bool[] alphabetFlags = new bool[26];

            // Iterate over each character in the sentence
            foreach (char c in sentence.ToLower())
            {
                if (c >= 'a' && c <= 'z')
                {
                    alphabetFlags[c - 'a'] = true;
                }
            }

            // Check if all letters are marked as present
            foreach (bool isPresent in alphabetFlags)
            {
                if (!isPresent)
                {
                    return false;
                }
            }

            return true;
        }
        static void checkPangram(int number)
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();

            if (IsPangram(input))
            {
                Console.WriteLine("The sentence is a pangram.");
            }
            else
            {
                Console.WriteLine("The sentence is not a pangram.");
            }
        }
    }
}
