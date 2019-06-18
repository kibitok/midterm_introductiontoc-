using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            

            greater();
            incrementation();
            Decrementation();
            f();
            division();

        }
        public static void greater()
        {
            int x;
            Console.WriteLine("Please Enter the value of x. :");
            x = Convert.ToInt32(Console.ReadLine());
            if (x > 10)
            {
                Console.WriteLine("x is greater than 10.\n");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("x is less than 10.\n");
                Console.ReadKey();
            }
        }
        public static void incrementation()
        {
            int? x, y,z;
            Console.WriteLine("Please Enter the value of x. :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the value of y. :");
            y = Convert.ToInt32(Console.ReadLine());
            
             z= x++ + y;

            Console.WriteLine("the remainder is "+ z);
            Console.ReadKey();


        }
        public static void Decrementation()
        {
            int x, total;
            Console.WriteLine("Please Enter the value of x. :");
            x = Convert.ToInt32(Console.ReadLine());
            total =- --x;

            Console.WriteLine("the sum is " + total);
            Console.ReadKey();
        }
        public static void f()
        {
            int x, total;
            Console.WriteLine("Please Enter the value of x. :");
            x = Convert.ToInt32(Console.ReadLine());
            total =+ --x;

            Console.WriteLine("value of total " + total);
            Console.ReadKey();
        }
        public static void division()
        {
            int q, divisor;
            Console.WriteLine("Please Enter the value of q. :");
           q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the value of divisor :");
            divisor = Convert.ToInt32(Console.ReadLine());
            q = q % divisor;
            q %= divisor;

            Console.WriteLine("the sum is " + q);
            Console.ReadKey();
        }
    }
}
