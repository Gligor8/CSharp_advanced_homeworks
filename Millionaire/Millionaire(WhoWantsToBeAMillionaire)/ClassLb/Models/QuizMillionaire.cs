using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLb.Models
{
    public class QuizMillionaire : Quiz
    {
        public Random md { get; set; }
        public Question[] questions15 { get; set; }

        public Dictionary<string, int> answerChoices { get; set; }
        public HelpAudience hAA { get; set; }
        public HelpFriend hCF { get; set; }
        public HelpFiftyFifty hFF { get; set; }

        public void ShufflePossibleQuestions()
        {

        }

        public void GenerateQuestion15()
        {

        }

        public void PrintQuestion(int questionNumber, Question q)
        {

        }
        public void PrintHelpOptions()
        {

        }

        public override void Start()
        {

        }
    }
}
