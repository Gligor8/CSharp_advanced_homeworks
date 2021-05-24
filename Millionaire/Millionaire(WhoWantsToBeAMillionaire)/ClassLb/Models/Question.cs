using System;

namespace ClassLb
{
    public class Question
    {
        public string Text { get; set; }
        public string[] PossibleAnswer { get; set; }
        public int correctAnswer { get; set; }
        public int SelectedAnswer { get; set; }
    }
}
