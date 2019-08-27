using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLogic010
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = Mod20(20);
            Console.WriteLine("b1 is:" + b1);

            bool b2= Mod20(21);
            Console.WriteLine("b2 is:" + b2);

            bool b3 = Mod20(22);
            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }
        public static bool Mod20(int n)
        {
            bool is20 = false;

            if(((n-1)%20==0)||((n-2)%20==0))
            {
                is20 = true;
            }

            return is20;
        }
    }
}
