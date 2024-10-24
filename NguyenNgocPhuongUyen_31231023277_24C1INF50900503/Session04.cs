
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace NguyenNgocPhuongUyen_31231023277_24C1INF50900503
{
    internal class Session04
    {
        public static void Main()
        {
            exercise2_3();
        }

        // EXERCISE 1: Operators
        /// <summary>
        /// 1. Write a C# Sharp program that takes two numbers as input and performs an operation(+,-,*, x,/) on them and displays the result of that operation.
        /// </summary>
        public static void exercise1_1()
        {

        }

        /// <summary>
        /// 2. Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        /// </summary>
        public static void exercise1_2()
        {

        }

        /// <summary>
        /// 3. Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour(km/h) and miles per hour(miles/h).
        /// </summary>
        public static void exercise1_3()
        {

        }

        /// <summary>
        /// 4. Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.V = 4/3*π* r^3
        /// </summary>
        public static void exercise1_4()
        {

        }

        /// <summary>
        /// 5. Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
        /// </summary>
        public static void exercise1_5()
        {

        }

        // EXERCISE 2: Control flow statements
        /// <summary>
        /// 1. Write a C# Sharp program to check whether a given number is even or odd.
        /// </summary>
        public static void exercise2_1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = 1;
            if (a % 2 == 0)
                Console.WriteLine($"{a} là số chẵn");
            else
                Console.WriteLine($"{a} là số lẻ");
            Console.ReadKey();
        }

        /// <summary>
        /// 2. Write a C# Sharp program to find the largest of three numbers.
        /// </summary>
        public static void exercise2_2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số a: "); 
            int a = int.Parse( Console.ReadLine() );
            Console.WriteLine("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số c: ");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if (b>max)
                max = b;
            if (c>max)
                max = c;
            Console.WriteLine("Số lớn nhất là "+max);
            Console.ReadKey();

        }

        ///<summary> 
        ///3. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        ///</summary> 
        public static void exercise2_3()
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.Write("Nhập tọa độ một điểm:\nX = ");
            int x=int.Parse(Console.ReadLine());
            Console.Write("Y = ");
            int y=int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Tọa độ thuộc phần tư thứ nhất");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Tọa độ thuộc phần tư thứ hai");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Tọa độ thuộc phần tư thứ ba");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Tọa độ thuộc phần tư thứ tư");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Tọa độ nằm trên trục tọa độ Oy");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Tọa độ nằm trên trục tọa độ Ox");
            }
            else
                Console.WriteLine("Tọa độ thuộc góc tọa độ O");
            Console.ReadLine();
        }

        /// <summary>
        /// page22: 1. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        /// </summary>
        public static void exercise2_4()
        {

        }

        /// <summary>
        /// page22: 2. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        /// </summary>
        public static void exercise2_5()
        {

        }

        /// <summary>
        /// page22: 3. Write a program to display the multiplication table of a given integer.
        /// </summary>
        public static void exercise2_6()
        {

        }

        /// <summary>
        /// page 22: 4. Write a program to display a pattern like triangles with a number.
        /// </summary>
        public static void exercise2_7()
        {

        }

        /// <summary>
        /// page 22: 5. The patterns like :
        /// </summary>
        public static void exercise2_8()
        {

        }

        /// <summary>
        /// page 22: 6. Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
        /// </summary>
        public static void exercise2_9()
        {

        }

        /// <summary>
        /// page 22: 7. Write a program to find the ‘perfect’ numbers within a given number range.
        /// </summary>
        public static void exercise2_10()
        {

        }

        ///<summary>
        /// page 22: 8. Write a program to determine whether a given number is prime or not.
        /// </summary>
        public static void exercise2_11()
        {

        }
    }
}