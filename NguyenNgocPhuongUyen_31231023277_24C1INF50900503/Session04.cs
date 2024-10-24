
using System.Text;

namespace NguyenNgocPhuongUyen_31231023277_24C1INF50900503
{
    internal class Session04
    {
        public static void Main()
        {
            exercise_03();
        }

        // 1. Kiểm tra xem một số cho trước là chẵn hay lẻ
        public static void exercise_01()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = 1;
            if (a % 2 == 0)
                Console.WriteLine($"{a} là số chẵn");
            else
                Console.WriteLine($"{a} là số lẻ");
            Console.ReadKey();
        }

        //2. Tìm số lớn nhất trong 3 số
        public static void exercise_02()
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
        /// 
        public static void exercise_03()
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

        public static void exercise_04()
        {
        }
    }
}