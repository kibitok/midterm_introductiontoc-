using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Program
    {
        static void Main(string[] args)
        {

            square();
            Circle();
            Arrow();
            diamond();

        }
        public static void square()
        {
            Console.WriteLine(" * * * * * * * * ");
            Console.ReadKey();
            Console.WriteLine(" *             * ");
            Console.ReadKey();
            Console.WriteLine(" *             * ");
            Console.ReadKey();
            Console.WriteLine(" *             * ");
            Console.ReadKey();
            Console.WriteLine(" *             * ");
            Console.ReadKey();
            Console.WriteLine(" *             * ");
            Console.ReadKey();
            Console.WriteLine(" *             * ");
            Console.ReadKey();
            Console.WriteLine(" *             * ");
            Console.ReadKey();
            Console.WriteLine(" * * * * * * * * ");
            Console.ReadKey();

        }
        public static void diamond()
        {
            Console.WriteLine("         *");
            Console.ReadKey();
            Console.WriteLine("     *       *");
            Console.ReadKey();
            Console.WriteLine("*                    *");
            Console.ReadKey();
            Console.WriteLine("     *       *");
            Console.ReadKey();
            Console.WriteLine("         *");
            Console.ReadKey();
        }
        public static void Circle()
        {
            Console.WriteLine("   * * *");
            Console.ReadKey();
            Console.WriteLine("  *     *");
            Console.ReadKey();
            Console.WriteLine(" *        *");
            Console.ReadKey();
            Console.WriteLine(" *        *");
            Console.ReadKey();
            Console.WriteLine(" *        *");
            Console.ReadKey();
            Console.WriteLine("  *       *");
            Console.ReadKey();
            Console.WriteLine("   *     *");
            Console.ReadKey();
            Console.WriteLine("    * * *");
            Console.ReadKey();
        }
        public static void Arrow()
        {
            Console.WriteLine("    * ");
            Console.ReadKey();
            Console.WriteLine("  * * * ");
            Console.ReadKey();
            Console.WriteLine("* * * * * ");
            Console.ReadKey();
            Console.WriteLine("    * ");
            Console.ReadKey();
            Console.WriteLine("    * ");
            Console.ReadKey();
            Console.WriteLine("    * ");
            Console.ReadKey();
            Console.WriteLine("    * ");
            Console.ReadKey();
            Console.WriteLine("    * ");
            Console.ReadKey();
            Console.WriteLine("    * ");
            Console.ReadKey();
        }

    }
}
