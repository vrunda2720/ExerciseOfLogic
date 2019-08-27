using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLogic014
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = AreInOrder(1, 2, 4, false);
            Console.WriteLine("b1 is:" + b1);

            bool b2 = AreInOrder(1, 2, 1, false);
            Console.WriteLine("b2 is:" + b2);

            bool b3 = AreInOrder(1, 1, 2, true);
            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }
        public static bool AreInOrder(int a, int b, int c, bool bOk)
        {
            bool isInorder = false;

           if(bOk==true)
            {
                if(c>b)
                {
                    isInorder = true;
                }
            }

           if((b>a)&&(c>b))
            {
                isInorder = true;
            }

            return isInorder;
        }
    }
}
