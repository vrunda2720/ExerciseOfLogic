using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLogic08
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = InRange(5, false);
            Console.WriteLine("b1 is:" + b1);

            bool b2 = InRange(11, false);
            Console.WriteLine("b2 is:" + b2);

            bool b3 = InRange(11, true);
            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }
        public static bool InRange(int n, bool outsideMode)
        {
            bool isRange = false;
            IEnumerable<int> R1 = Enumerable.Range(1, 10);

            if(R1.Contains(n)||outsideMode==true)
            {
                isRange = true;
            }

            return isRange;
        }
    }
}
