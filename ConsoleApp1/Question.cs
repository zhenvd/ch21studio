using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Question
    {
        public double CorrectAnswer { get; set; } = 0;
        public string QuestionType { get; set; }
        public double Percentage { get; set; }
        public double NoOfQuestions { get; set; } = 0;

        public Question(){}
        public Question(string questionType)
        {
            QuestionType = questionType;
            if (String.IsNullOrEmpty(questionType))
            {
                throw new ArgumentNullException(questionType, "Question type required.");
            } 
        }

        //outputs score
        /*public void Score()
        {
            //score = correctAnswer;
            Percentage = Math.Round(CorrectAnswer / NoOfQuestions);
            Console.WriteLine($"You got {CorrectAnswer} out of {NoOfQuestions} correct. Your score is {Percentage}%.");
        }*/
    }
}
