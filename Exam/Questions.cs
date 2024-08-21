using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Questions : Exam
    {
        public Questions(DateTime dateOfExam, int numberOfQuestions) : base(dateOfExam, numberOfQuestions) {}

        private int selectedQuestion;
        private string chooises;
        private string questionLevel;
        private string question;
        private int questionMark;
        private string answer;

        protected static List<int> selectedQuestions = new List<int>();
        public static List<string> questionLevels = new List<string>();
        public static List<string> questions = new List<string>();
        public static List<int> questionMarks = new List<int>();
        public static List<string> answers = new List<string>();
        public static List<string> allChooises = new List<string>();
        public static List<string> multipleChoises = new List<string>();

        private bool CheckLevel()
        {
            do
            {
                Console.Write("Enter Questions Level Select Between [Easy - Mid - Hard] Only:  ");
                questionLevel = Console.ReadLine();
                
            } while (questionLevel != "Easy" && questionLevel != "Mid" && questionLevel != "Hard");

            questionLevels.Add(questionLevel);
            return true;
        }
        private bool CheckQuestion()
        {
            do
            {
                Console.Write("Enter The Questions With at Least 3 Chars :  ");
                question = Console.ReadLine();
            } while (question.Length < 3);

            questions.Add(question);
            return true;
        }
        private bool CheckQuestionMark()
        {
            do
            {
                Console.Write("Enter The Mark Of Questions And Must Be A Number At Least Equal '1' :  ");
                questionMark = int.Parse(Console.ReadLine());
            } while (questionMark <= 0);

            GradeOfExam += questionMark;
            questionMarks.Add(questionMark);
            return true;
        }
        public override void StartExam()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine("\n=========== Choose Type Of Question ===========\n");
                
                do
                {
                    Console.WriteLine("1- True Or False Question");
                    Console.WriteLine("2- Choose One Question");
                    Console.WriteLine("3- MultipleChoise Question");
                    Console.Write("Choose Between [ 1 - 2 - 3 ]  ");
                    selectedQuestion = int.Parse(Console.ReadLine());
                    selectedQuestions.Add(selectedQuestion);

                    switch (selectedQuestion)
                    {
                        case 1:
                            CheckLevel();                      

                            CheckQuestion();

                            CheckQuestionMark();                            

                            do
                            {
                                Console.Write("Select The Right Answer (True/False):  ");
                                answer = Console.ReadLine();
                            } while(answer != "True" && answer != "False");
                            answers.Add(answer);
                            break;

                        case 2:
                            CheckLevel();

                            CheckQuestion();

                            CheckQuestionMark();

                            for (int j = 0; j < 4; j++)
                            {
                                Console.Write($"Select The Choose Number {j + 1}:  ");
                                chooises = Console.ReadLine();
                                allChooises.Add(chooises);
                            }

                            do
                            {
                                Console.Write("Select The Right Answer (1 - 2 - 3 - 4):  ");
                                answer = Console.ReadLine();
                            } while (answer != "1" && answer != "2" && answer != "3" && answer != "4");
                            answers.Add(answer);
                            break;

                        case 3:
                            CheckLevel();

                            CheckQuestion();

                            CheckQuestionMark();

                            for (int j = 0; j < 3; j++)
                            {
                                Console.Write($"Select The Choose Number {j + 1}:  ");
                                chooises = Console.ReadLine();
                                multipleChoises.Add(chooises);
                            }

                            do
                            {
                                Console.Write("Select The Right Answer Selected as 1/2..1/2/3:  ");
                                answer = Console.ReadLine();
                            } while (answer != "1/2" && answer != "1/3" && answer != "2/3" && answer != "1/2/3");                                                        
                            answers.Add(answer);
                            break;
                    }

                } while (selectedQuestion != 1 && selectedQuestion != 2 && selectedQuestion != 3);
            }
        }

    }
}
