using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NguyenNgocPhuongUyen_31231023277_24C1INF50900503
{
    internal class Session04
    {
        public static void Main()
        {
            exercise2_10();
        }

        // EXERCISE 1: Operators
        /// <summary>
        /// 1. Write a C# Sharp program that takes two numbers as input and performs an operation(+,-,*, x,/) on them and displays the result of that operation.
        /// </summary>
        public static void exercise1_1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số thứ nhất: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ hai: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("1. Thực hiện phép cộng");
            Console.WriteLine("2. Thực hiện phép trừ");
            Console.WriteLine("3. Thực hiện phép nhân");
            Console.WriteLine("4. Thực hiện phép chia");
            Console.WriteLine("5. Thực hiện phép chia lấy dư");
            Console.WriteLine("Nhập 1 số để thực hiện phép tính");

            byte choice = byte.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{a}+{b}={a + b}");
                    break;
                case 2:
                    Console.WriteLine($"{a}-{b}={a - b}");
                    break;
                case 3:
                    Console.WriteLine($"{a}*{b}={a * b}");
                    break;
                case 4:
                    if (b != 0) Console.WriteLine($"{a}/{b}={a / b}");
                    else Console.WriteLine("Không thực hiện được phép chia với mẫu bằng 0");
                    break;
                case 5:
                    if (b != 0) Console.WriteLine($"{a}%{b}={a % b}");
                    else Console.WriteLine("Không thực hiện được phép chia với mẫu bằng 0");
                    break;
            }
        }

        /// <summary>
        /// 2. Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        /// </summary>
        public static void exercise1_2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập giá trị của y (-5 <= y <= 5): ");
            int y = int.Parse(Console.ReadLine());
            if (y >= -5 && y <= 5)
            {
                float x = y * y + 2 * y + 1;
                Console.WriteLine($"y = {y} \n" +
                   $"x = {x}");
            }
            else
                Console.WriteLine("Giá trị y không hợp lệ (-5 <= y <= 5)");
        }

        /// <summary>
        /// 3. Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour(km/h) and miles per hour(miles/h).
        /// </summary>
        public static void exercise1_3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập quãng đường đi (km): ");
            float d = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số giờ: ");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số phút: ");
            float m = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số giây: ");
            float s = float.Parse(Console.ReadLine());

            float t = h + (m / 60) + (s / 3600);
            Console.WriteLine($"Vận tốc di chuyển là {d/t} (km/h)");
            Console.WriteLine($"Vận tốc di chuyển là {d*0.62137/t} (miles/h)");
        }

        /// <summary>
        /// 4. Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.V = 4/3*π* r^3
        /// </summary>
        public static void exercise1_4()
        {
            Console.OutputEncoding = Encoding.UTF8;
            const float PI = (float)Math.PI;
            Console.WriteLine("Nhập bán kính hình cầu: ");
            int r = int.Parse(Console.ReadLine());
            float Sxp = 4 * PI * r * r;
            float V = (4 * PI * r * r * r)/3;
            Console.WriteLine("Diện tích xung quanh của hình cầu là "+Sxp);
            Console.WriteLine("Thể tích hình cầu là "+V);
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
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số c: ");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            Console.WriteLine("Số lớn nhất là " + max);
            Console.ReadKey();

        }

        ///<summary> 
        ///3. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        ///</summary> 
        public static void exercise2_3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập tọa độ một điểm:\nX = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y = ");
            int y = int.Parse(Console.ReadLine());

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
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập độ dài cạnh AB: ");
            int ab = int.Parse(Console.ReadLine());
            Console.Write("Nhập độ dài cạnh AC: ");
            int ac = int.Parse(Console.ReadLine());
            Console.Write("Nhập độ dài cạnh BC: ");
            int bc = int.Parse(Console.ReadLine());

            if (ab == ac && ab == bc)
                Console.WriteLine("Tam giác ABC là tam giác đều");
            else if (ab == ac && ab != bc)
                Console.WriteLine("Tam giác ABC là tam giác cân tại A");
            else if (ab == bc && ab != ac)
                Console.WriteLine("Tam giác ABC là tam giác cân tại B");
            else if (ac == bc && ac != ab)
                Console.WriteLine("Tam giác ABC là tam giác cân tại C");
            else
                if (ab + bc > ac && ab + ac > bc && ac + bc > ab)
                Console.WriteLine("Tam giác ABC là tam giác thường");
                else
                Console.WriteLine("Độ dài ba cạnh bạn nhập không tạo thành tam giác");
        }

        /// <summary>
        /// page22: 2. Write a program to read 10 numbers and find their average and sum.
        /// </summary>
        public static void exercise2_5()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int count = 10;
            double sum = 0;
            for (int i = 1; i <= count; i++)
            {
                Console.Write("Nhập số bạn cần tính: ");
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            double avr = sum / count;
            Console.WriteLine("Tổng của 10 số là " + sum);
            Console.WriteLine("Trung bình cộng của 10 số là "+ avr);
        }

        /// <summary>
        /// page22: 3. Write a program to display the multiplication table of a given integer.
        /// </summary>
        public static void exercise2_6()
        {
            Console.Write("Nhap 1 so nguyen de hien thi bang nhan: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2;i <= num;i++)
            {
                for (int j = 1;j <= 10;j++)
                {
                    Console.WriteLine($"{i}*{j}={i*j}");
                }
                Console.WriteLine();
            }    
        }
        ///<summary>
        /// page 22: 4&5. Write a program to display a pattern like triangles with a number. The pattern like:
        ///</summary>
        public static void exercise2_7()
        {
            Console.Write("Nhap mot so: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Pattern 1");
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Pattern 2");
            int beg = 1;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(beg + " ");
                    beg++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Pattern 3");
            int sta = 1;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{sta,-2}"); // sử dụng -2 để căn chỉnh số
                    sta++;
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// page 22: 6. Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
        /// </summary>
        public static void exercise2_8()
        {
            Console.Write("Nhap so hang n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            Console.WriteLine("Day so voi so hang {0} la: ", n);
            for (int i = 1;i <= n;i++)
            {
                sum = (sum*i + 1)/i;
                Console.Write($"1/{i}");
                if (i < n)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tong can tim la "+sum);
        }

        /// <summary>
        /// page 22: 7. Write a program to find the ‘perfect’ numbers within a given number range.
        /// </summary>
        public static void exercise2_9()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập phạm vi tìm số hoàn hảo \nSố bắt đầu: ");
            int beg = int.Parse(Console.ReadLine());
            Console.Write("Số kết thúc: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"Số hoàn hảo trong khoảng từ {beg} đến {end} là:");
            for (int i = beg; i <= end; i++)
            {
                int sum = 0;
                for (int j = 1;j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if (i == sum)
                    Console.WriteLine(+i);
            }
        }

        ///<summary>
        /// page 22: 8. Write a program to determine whether a given number is prime or not.
        /// </summary>
        public static void exercise2_10()
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.Write("Nhập 1 số nguyên: ");
            int n = int.Parse(Console.ReadLine());
            int demUoc = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    demUoc++;
            }
            if (demUoc == 2)
                Console.WriteLine($"Số {n} là số nguyên tố");
            else
                Console.WriteLine($"Số {n} không phải là số nguyên tố");
        }
    }
}