
using System.Text;

namespace NguyenNgocPhuongUyen_31231023277_24C1INF50900503
{
    internal class Session02
    {
        public static void Main()
        {
            Question_01();
        }
        //Write programs that:
        // 1. to Add / Sum Two Numbers.
        public static void Question_01()
        {
            Console.WriteLine("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"{a}+{b}={c}");
        }

        // 2. to Swap Values of Two Variables.
        public static void Question_02()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            Console.WriteLine($"a={b}");
            b = c;
            Console.WriteLine($"b={c}");
        }

        // 3. to Multiply two Floating Point Numbers
        public static void Question_03()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = a * b;
            Console.WriteLine($"{a}*{b}={a * b}");
        }

        // 4. to convert feet to meter
        public static void Question_04()
        {
            Console.Write("Enter number of feet: ");
            float f = float.Parse(Console.ReadLine());
            double m = f * 0.3048;
            Console.WriteLine($"{f} feet = {m} meters");

        }

        // 5. to convert Celsius to Fahrenheit and vice versa
        public static void Question_05_01()
        {
            // convert Celsius to Fahrenheit
            float C;
                Console.Write("Enter number of C: ");
                C = float.Parse(Console.ReadLine());
                double F = ((float)C * 1.8) + 32;
                Console.WriteLine($"{C} Celsius = {F} Fahrenheit");
        }

        // convert Fahrenheit to Celsius
        public static void Question_05_02()
        {
            double F;
            Console.Write("Enter number of F: ");
            F = double.Parse(Console.ReadLine());
            double C = ((double)F - 32) / 1.8;
            Console.WriteLine("{0} Fahrenheit = {1} Celsius", F, C);
        }

        // 6. to find the Size of data types
        public static void Question_06()
        {
            int s = sizeof(float);
            Console.WriteLine($"Kich thuoc kieu du kieu la: {s}");

        }

        // 7. to Print ASCII Value (tip: read character, print number of this char)
        public static void Question_07()
        {
            char c = 'a';
            int num = c;
            Console.WriteLine($"{c} in ASCII = {num}");
        }

        // 8. to Calculate Area of Circle
        public static void Question_08()
        {
            const float PI = 3.14f;
            Console.Write("Nhap ban kinh hinh tron: ");
            float r = float.Parse(Console.ReadLine());
            float S = r * r * PI;
            Console.WriteLine("Dien tich hinh tron la {0}", S);

        }

        // 9. to Calculate Area of Square
        public static void Question_09()
        {
            Console.Write("Nhap do dai canh hinh vuong: ");
            float a = float.Parse(Console.ReadLine());
            float S = a * a;
            Console.WriteLine("Dien tich hinh vuong la {0}", S);
        }

        // 10. to convert days to years, weeks and days
        public static void Question_10()
        {
            Console.WriteLine("Nhap so ngay can tinh:");
            int days = int.Parse(Console.ReadLine());
            int year = days / 365;
            int week = (days - year * 365) / 7;
            int day = (days - week * 7) % 7;
            Console.WriteLine($"{days} days= {year} years, {week} weeks), {day} days");
        }
    }
}
