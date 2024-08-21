using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class Exam
    {
        public DateTime DateOfExam { get; set; }
        public int NumberOfQuestions { get; set; }

        public static int GradeOfExam = 0;

        public Exam(DateTime dateOfExam, int numberOfQuestions)
        {
            DateOfExam = dateOfExam;
            NumberOfQuestions = numberOfQuestions;            
        }
        public abstract void StartExam();
    }
}
