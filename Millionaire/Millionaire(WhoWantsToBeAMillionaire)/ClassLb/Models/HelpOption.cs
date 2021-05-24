using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLb.Models
{
    public class HelpOption
    {
        public string Name { get; set; }
        public bool IsUsed { get; set; }
        public Random rnd { get; set; }

        public HelpOption()
        {

        }

        public virtual void UseHelpOption(Question q, Dictionary<string, int> answerChoices)
        {

        }
    }
}
