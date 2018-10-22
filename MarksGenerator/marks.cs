using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksGenerator
{
    class marks
    {
        static void Main() {
            int total;
            

            Console.Write("Science: ");
            int sc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maths: ");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.Write("English: ");
            int english = Convert.ToInt32(Console.ReadLine());

            total = sc + maths + english;
            Console.Write("Total mark is: {0} \n",total);
            //grade for Science
            if (sc >= 75)
            {
                Console.Write("Grade for Science: A \n");
            }
            else if(sc<75 && sc>=65)
            {
                Console.Write("Grade for Science: B \n");
            }
            else if (sc < 65 && sc >= 55)
            {
                Console.Write("Grade for Science: C \n");
            }
            else if (sc < 55 && sc >= 45)
            {
                Console.Write("Grade for Science: S \n");
            }
            else
            {
                Console.Write("Grade for Science: F \n");
            }
            //End

            //grade for Maths
            if (maths >= 75)
            {
                Console.Write("Grade for Maths: A \n");
            }
            else if (maths < 75 && maths >= 65)
            {
                Console.Write("Grade for Maths: B \n");
            }
            else if (maths < 65 && maths >= 55)
            {
                Console.Write("Grade for Maths: C \n");
            }
            else if (maths < 55 && maths >= 45)
            {
                Console.Write("Grade for Maths: S \n");
            }
            else
            {
                Console.Write("Grade for Maths: F \n");
            }
            //End

            //grade for English
            if (english >= 75)
            {
                Console.Write("Grade for English: A \n");
            }
            else if (english < 75 && english >= 65)
            {
                Console.Write("Grade for English: B \n");
            }
            else if (english < 65 && english >= 55)
            {
                Console.Write("Grade for English: C \n");
            }
            else if (english < 55 && english >= 45)
            {
                Console.Write("Grade for English: S \n");
            }
            else
            {
                Console.Write("Grade for English: F \n");
            }
            //End
            total = sc + maths + english;
            Console.Write("Total mark is: {0} \n", total);
            avg = (total / 3);
            Console.Write("Total mark is: {0} \n", total);
            Console.ReadKey();
        }

    }
}
