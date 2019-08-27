using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLogic011
{
    class Program
    {
        static void Main(string[] args)
        {
           bool b1= Mod35(3);
            Console.WriteLine("b1 is:" + b1);

            bool b2 = Mod35(10);
            Console.WriteLine("b2 is:" + b2);

            bool b3 = Mod35(15);
            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }
        public static bool Mod35(int n)
        {
            bool is35 = false;

            if((n%3==0)^(n%5==0))
            {
                is35 = true;
            }

            return is35;

        }
    }
}
