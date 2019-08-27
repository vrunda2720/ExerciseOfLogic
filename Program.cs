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
            bool b1 = GreatParty(30,false);

            Console.WriteLine("b1 is:" + b1);

            bool b2 = GreatParty(50, false);

            Console.WriteLine("b2 is:" + b2);

            bool b3 = GreatParty(70, true);

            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }
        public static bool GreatParty(int cigars, bool isWeekend)
        {
            bool isParty = false;
            if((cigars>=40)&&(cigars<=60||isWeekend))
            {
                isParty = true;
            }
            
            return isParty;
        }
    }
}
