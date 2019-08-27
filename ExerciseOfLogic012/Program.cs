using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLogic012
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = AnswerCell(false, false, false);
            Console.WriteLine("b1 is:" + b1);

            bool b2 = AnswerCell(false, false, true);
            Console.WriteLine("b2 is:" + b2);

            bool b3 = AnswerCell(true, false, false);
            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }
        public static bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            bool isAnswer = false;

            if((isMorning==false)&&(isMom==false)&&(isAsleep==false))
            {
                isAnswer = true;
            }

            return isAnswer;
        }

    }
}
