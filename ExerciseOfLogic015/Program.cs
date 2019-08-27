using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLogic015
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = InOrderEqual(2, 5, 11, false);
            Console.WriteLine("b1 is:" + b1);

            bool b2 = InOrderEqual(5, 7, 6, false);
            Console.WriteLine("b2 is:" + b2);

            bool b3 = InOrderEqual(5, 5, 7, true);
            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }
        public static bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            bool isEqual = false;

            if(equalOk==true)
            {
                if((a<=b)&&(b<=c))
                {
                    isEqual = true;
                }
            }

            if((a<b)&&(b<c))
            {
                isEqual = true;
            }

            return isEqual;
        }
    }
}
