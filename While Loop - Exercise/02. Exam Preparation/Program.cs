using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int badGrades = int.Parse(Console.ReadLine());

            int failedTimes = 0;
            int solvedProblemsCount = 0;
            double sumGrades = 0;
            string lastProblem = " ";
            bool isFailed = true;

            while (failedTimes <badGrades)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;
                }
                sumGrades+=grade;
                solvedProblemsCount++;
                lastProblem=problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {badGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {(sumGrades/solvedProblemsCount):f2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }


        }
    }
}
