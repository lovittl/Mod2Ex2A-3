using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Ex2A_3
{
    class Program
    {
        static void Main(string[] args)

        {  // declare values to hold test values and perform calculation
            int i, n, ns, sum = 0;
            double avg;
            

            //illicit input
            Console.Write("\n\n");
            Console.Write("Enter number of scores to be entered:");
            ns = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter {0} scores between 0 and 100 and calculate Average:\n", ns);
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the {0} scores : \n", ns);

            for (i = 1; i <= ns; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            //calculate average and assign to varabila avg
            avg = sum / 10.0;

            Console.Write("\nThe Average is : {0}\n", avg);
            Console.WriteLine("Your letter grade is : {0}\n", (GetGrade(avg)));
        }
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
