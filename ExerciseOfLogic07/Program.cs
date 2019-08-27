using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLogic07
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = LoveSix(6, 4);
            Console.WriteLine("b1 is:" + b1);

            bool b2 = LoveSix(4, 5);
            Console.WriteLine("b2 is:" + b2);

            bool b3 = LoveSix(1, 5);
            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }
        public static bool LoveSix(int a, int b)
        {
            bool isSix = false;

            if ((a==6)||(b==6)||(a+b==6)||(a-b==6))
            {
                isSix = true;
            }

            return isSix;
        }

    }
}
