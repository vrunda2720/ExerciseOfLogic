using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLogic017
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = RollDice(2, 3, true);
            Console.WriteLine("i1 is:" + i1);

            int i2 = RollDice(3, 3, true);
            Console.WriteLine("i2 is:" + i2);

            int i3 = RollDice(3, 3, false);
            Console.WriteLine("i3 is:" + i3);
            Console.ReadLine();
        }
        public static int RollDice(int die1, int die2, bool noDoubles)
        {
            IEnumerable<int> i = Enumerable.Range(1, 6);

            var sum = die1 + die2;
            if (noDoubles)
            {
                if (i.Contains(sum) && (die1 == die2))
                {
                    return sum + 1;
                }
            }
            return sum;

            


        }
    }
}
