using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Average a non-specific number of scores
Create a console application that will accept a number test scores(as calculated by the number of scores actually entered) between 0 and 100, 
average them, and report a letter grade for the average based on the usual scale.For example, a teacher will input any number test scores, 
and see the average numerical grade and the letter grade.
*/
    namespace Mod2Ex2Ad
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            double avg;
            //string LetGrade;

            //illicit input
            Console.Write("\n\n");
            Console.Write("When done entering scores between 0 and 100 enter -1 : \n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the scores : \n");
            n = 1;
            while (n != -1)
            {
                
            Console.Write("Number-{0} :", i);
                i++;
            n = Convert.ToInt32(Console.ReadLine());
            sum += n;
            }

            //for (i = 1; i != -1; i++)
            //{
            //    Console.Write("Number-{0} :", i);

            //    n = Convert.ToInt32(Console.ReadLine());
            //    sum += n;
            //}
            //calculate average and assign to varabila avg
            avg = sum / 10.0;

            Console.Write("\nThe Average is : {0}\n", avg);
            Console.WriteLine("Your letter grade is : {0}\n", (GetGrade(avg)));
        }  // end main

        //assigns a letter grade based on numerical value
        static char GetGrade(double LetGrade)
        {
            int avg = 0;
            char let;
            Console.ReadKey();
            if (avg >= 90 && avg <= 100)
            {
                let = 'A';
            }
            else if (avg >= 80 && avg <= 89)
            {
                let = 'B';
            }
            else if (avg >= 70 && avg <= 79)
            {
                let = 'C';
            }
            else if (avg >= 60 && avg <= 69)
            {
                let = 'D';
            }
            else if (avg >= 0 && avg <= 59)
            {
                let = 'F';
            }
            else
            {
                Console.WriteLine("numbers entered out of bounds");
                return 'x';
            }

            return let;
        }



    }
}
