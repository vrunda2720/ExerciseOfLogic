using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLogic013
{
    class Program
    {
        static void Main(string[] args)
        {
         bool b1=   TwoIsOne(1, 2, 3);
            Console.WriteLine("b1 is:" + b1);

            bool b2 = TwoIsOne(3, 1, 2);
            Console.WriteLine("b2 is:" + b2);

            bool b3 = TwoIsOne(3, 2, 2);
            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }
        public static bool TwoIsOne(int a, int b, int c)
        {
            bool isSum = false;

            if(((a==(b+c))||(b==(a+c))||(c==(a+b))))
                {
                isSum = true;
            }

            return isSum;
        }
    }
}
