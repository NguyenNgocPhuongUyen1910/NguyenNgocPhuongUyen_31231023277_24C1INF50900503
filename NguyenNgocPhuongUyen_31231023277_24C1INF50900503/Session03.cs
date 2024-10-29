
using System.Text;

namespace NguyenNgocPhuongUyen_31231023277_24C1INF50900503
{
    internal class Session03
    {
            public static void Main()
            {
                Question_01();
            }

        // 1. Create a C# program to convert from degrees Celsius to Kelvin and Fahrenheit.
            public static void Question_01()
            {
                float C;
                Console.Write("Enter number of C: ");
                C = float.Parse(Console.ReadLine());
                double Kelvin = (float)C + 273;
                double F = ((float)C * 1.8) + 32;
                Console.WriteLine($"{C} Celsius = {Kelvin} Kelvin");
                Console.WriteLine($"{C} Celsius = {F} Fahrenheit");
        }

        // 2. Create a program in C# for calculate the surface and volume of a sphere, given its radius.
            public static void Question_02()
            {
                const float PI = 3.14f;
                Console.Write("Nhap ban kinh hinh cau: ");
                float r = float.Parse(Console.ReadLine());
                float S = 4 * PI * r * r;
                float V = 4 / 3 * PI * r * r * r;
                Console.WriteLine("Dien tich hinh cau la {0}", S);
                Console.WriteLine("The tich hinh cau la {0}", V);
                Console.ReadKey();
            }

        // 3. Write a program in C# that calculates the result of adding, subtracting, multiplying and dividing two numbers entered by the user.
            public static void Question_03()
            {
                float a, b;
                Console.Write("Nhap gia tri a: ");
                a = float.Parse(Console.ReadLine());
                Console.Write("Nhap gia tri b: ");
                b = float.Parse(Console.ReadLine());
                float x1 = a + b;
                float x2 = a - b;
                float x3 = a * b;
                float x4 = a / b;
                float x5 = a % b;
                Console.WriteLine($"{a}+{b}={x1}");
                Console.WriteLine($"{a}-{b}={x2}");
                Console.WriteLine($"{a}*{b}={x3}");
                Console.WriteLine($"{a}/{b}={x4}");
                Console.WriteLine($"{a}%{b}={x5}");
                Console.ReadKey();
            }
    }
}
