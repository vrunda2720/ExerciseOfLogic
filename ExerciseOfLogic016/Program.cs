using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLogic016
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = LastDigit(23, 19, 13);
            Console.WriteLine("b1 is:" + b1);

            bool b2 = LastDigit(23, 19, 12);
            Console.WriteLine("b2 is:" + b2);

            bool b3 = LastDigit(23, 19, 3);
            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }
        public static bool LastDigit(int a, int b, int c)
        {
            bool isLast = false;

            int A1 = a % 10;

            int B1 = b % 10;

            int C1 = c % 10;

            if((A1==B1)||(B1==C1)||(C1==A1))
            {
                isLast = true;
            }

            return isLast;
        }
    }
}
