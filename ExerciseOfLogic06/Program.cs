using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLogic06
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = AlarmClock(1, false);
            Console.WriteLine("s1 is:" + s1);

            string s2 = AlarmClock(5, false);
            Console.WriteLine("s2 is:" + s2);

            string s3 = AlarmClock(0, false);
            Console.WriteLine("s3 is:" + s3);
            Console.ReadLine();
        }
        public static string AlarmClock(int day, bool vacation)
        {

           
            if((day==0)||(day==6))
            {
                return "10:00";
            }
            return "7:00";
        }
    }
}
