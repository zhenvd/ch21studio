using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Quiz : Question
    {
        Dictionary<string, string> TFquestions = new Dictionary<string, string>();
        //List<string> MCquestionsList = new List<string>();
        Dictionary<string, List<string>> MCquestions = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> CheckQuestions = new Dictionary<string, List<string>>();  
        string userAnswer;

        public void AddTFQuestion(string answer, string question)
        {
            TFquestions.Add(answer, question);
            NoOfQuestions++;
        }
        public void AddMCQuestion(string answer, List<string> questions)
        {
            MCquestions.Add(answer, questions);
            NoOfQuestions++;
        }
        public void AddCheckQuestion(string answer, List<string> questions)
        {
            CheckQuestions.Add(answer, questions);
            NoOfQuestions++;
        }

        public void AskQuestions()
        {
            foreach(KeyValuePair<string, string> question in TFquestions)
            {
                Console.WriteLine(question.Value);
                userAnswer = Console.ReadLine();
                if(userAnswer.Equals(question.Key))
                {
                    CorrectAnswer++;
                }
            }
            foreach (string answer in MCquestions.Keys)
            {
                foreach(string questions in MCquestions[answer])
                {
                    Console.WriteLine(questions);
                }
                userAnswer = Console.ReadLine();
                if (userAnswer.Equals(answer))
                {
                    CorrectAnswer++;
                }
            }
            foreach (string answer in CheckQuestions.Keys)
            {
                foreach (string questions in CheckQuestions[answer])
                {
                    Console.WriteLine(questions);
                }
                userAnswer = Console.ReadLine().Trim();
                if (userAnswer.Equals(answer))
                {
                    CorrectAnswer++;
                }
            }
            //Console.WriteLine(question.Value);
            GradeQuiz();
        }

        public void GradeQuiz()
        {
            Percentage = CorrectAnswer / NoOfQuestions*100;
            Console.WriteLine($"You got {CorrectAnswer} out of {NoOfQuestions} correct. Your score is {Percentage}%.");
        }
    }

    
}
