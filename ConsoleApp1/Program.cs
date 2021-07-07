using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> lotr = new List<String>() { "Which of the following is the name of the wizard in LOTR?", "A. Gandalf", "B. Chip", "C. Chocolate" };
            List<String> pokemon = new List<String>() { "Which of the following is a pokemon?", "A. Gandalf", "B. Pickachu", "C. Charmander" };
            Quiz test = new Quiz();
            test.AddTFQuestion("true", "True or False: The sky is blue");
            //test.AskQuestions();
            test.AddMCQuestion("A", lotr);
            test.AddCheckQuestion("BC", pokemon);
            test.AskQuestions();

        }
    }
}
