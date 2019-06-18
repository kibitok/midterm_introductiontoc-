using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int sum = 0;

            Console.Write("The first 10 natural number are :\n");
            Console.ReadKey();

            int j = 1;
            while ( j<10)
            {
                sum = sum + j;
                j++;
            }
            Console.Write("\nThe Sum is : {0}\n", sum);
            Console.ReadKey();
        }
    }
}
    
