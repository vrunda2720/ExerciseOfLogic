using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLogic04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = CaughtSpeeding(60, false);
            Console.WriteLine("i1 is:" + i1);

            int i2 = CaughtSpeeding(65, false);
            Console.WriteLine("i2 is:" + i2);

            int i3 = CaughtSpeeding(65, true);
            Console.WriteLine("i3 is:" + i3);
            Console.ReadLine();
        }
        public static int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (speed <= 60 || isBirthday )
            {
                return 0;
            }
            else if ((speed >60)  && (speed <= 80||isBirthday))
            {
                return 1;
            }
            return 2;
        }
    }
}
