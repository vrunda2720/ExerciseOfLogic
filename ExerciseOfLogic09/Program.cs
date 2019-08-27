using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLogic09
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = SpecialEleven(22);
            Console.WriteLine("b1 is:" + b1);

            bool b2 = SpecialEleven(23);
            Console.WriteLine("b2 is:" + b2);

            bool b3 = SpecialEleven(24);
            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }
        public static bool SpecialEleven(int n)
        {
            bool isEvent = false;

            if((n%11==0)||((n-1)%11==0))
            {
                isEvent = true;
            }

            return isEvent;
        }
    }
}
