using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = PlayOutside(70, false);
            Console.WriteLine("b1 is:" + b1);

            bool b2 = PlayOutside(95, false);
            Console.WriteLine("b2 is:" + b2);

            bool b3 = PlayOutside(95, true);
            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }
        public static bool PlayOutside(int temp, bool isSummer)
        {
            bool isPlay = false;
            if((temp>=60)&&(temp<=90||isSummer))
            {
                isPlay = true;
            }

            return isPlay;
        }
    }
}
