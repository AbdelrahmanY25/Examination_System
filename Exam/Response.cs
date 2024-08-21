using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Response : Questions
    {
        public Response(DateTime dateOfExam, int numberOfQuestions) : base(dateOfExam, numberOfQuestions) {}

        private string studentAnswer;
        private int studentGrades;

        public override void StartExam()
        {            
            Console.WriteLine($"\t\tExam Date: {DateOfExam}\n");            
            Console.WriteLine($"Let's Answer On The Following Questions The Total Gareds Of Exam : {GradeOfExam}\n");

            // Start Looping To Show Questions To Student
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                if (selectedQuestions[i] == 1)
                {
                    do
                    {
                        Console.WriteLine("True Or False Question Answer By [True - False] Only: ");
                        Console.WriteLine($"{questions[i]} \t\t\t Level : {questionLevels[i]}");
                        Console.Write("Enter Your Answer: ");
                        studentAnswer = Console.ReadLine();
                    } while (studentAnswer != "True" && studentAnswer != "False");

                    if (studentAnswer == answers[i])
                    {
                        studentGrades += questionMarks[i];
                    }
                }
                else if (selectedQuestions[i] == 2)
                {
                    do
                    {
                        Console.WriteLine("Choose Question Choose Between ( 1 - 2 - 3 - 4 ) Select One Answer: ");
                        Console.WriteLine($"{questions[i]} \t\t\t Level : {questionLevels[i]}");

                        for (int j = 0; j < allChooises.Count; j++)
                        {
                            Console.WriteLine($"{j + 1}- {allChooises[j]}");
                        }
                        Console.Write("Enter Your Answer: ");
                        studentAnswer = Console.ReadLine();
                    } while (studentAnswer != "1" && studentAnswer != "2" && studentAnswer != "3" && studentAnswer != "4");

                    if (studentAnswer == answers[i])
                    {
                        studentGrades += questionMarks[i];
                    }
                }
                else
                {
                    do
                    {
                        Console.WriteLine("MultipleChoise Question Choose Between ( 1/2 - 2/3 - 1/3 - 1/2/3 ): ");
                        Console.WriteLine($"{questions[i]} \t\t\t Level : {questionLevels[i]}");

                        for (int j = 0; j < multipleChoises.Count; j++)
                        {
                            Console.WriteLine($"{j + 1}- {multipleChoises[j]}");
                        }
                        Console.Write("Enter Your Answer: ");
                        studentAnswer = Console.ReadLine();
                    } while (studentAnswer != "1/2" && studentAnswer != "1/3" && studentAnswer != "2/3" && studentAnswer != "1/2/3");

                    if (studentAnswer == answers[i])
                    {
                        studentGrades += questionMarks[i];
                    }
                }
                Console.WriteLine("\n===================================================\n");
            }

            Console.WriteLine("======================= Answers =======================");
            Console.WriteLine("The Right Answers Of Questions Is: ");
            foreach(var ans in answers)
            {
                Console.WriteLine($"- {ans}");
            }

            Console.WriteLine("======================= Your Result =======================");
            Console.WriteLine($"Your Grade Is {studentGrades} From {GradeOfExam}");
        }
    }
}
