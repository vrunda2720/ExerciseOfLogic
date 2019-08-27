using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLogic05
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = SkipSum(3, 4);
            Console.WriteLine("i1 is:" + i1);

            int i2 = SkipSum(9, 4);
            Console.WriteLine("i2 is:" + i2);

            int i3 = SkipSum(10, 11);
            Console.WriteLine("i3 is:" + i3);
            Console.ReadLine();
        }
        public static int SkipSum(int a, int b)
        {
            //IEnumerable<int> i = Enumerable.Range(10, 10);

            var sum = a + b;

            if((sum>=10)&&(sum<20))
            {
                return 20;
            }

            return sum;
        }
    }
}
