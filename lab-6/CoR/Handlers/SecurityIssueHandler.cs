using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6.CoR.Handlers
{
    public class SecurityIssueHandler : SupportHandler
    {
        public SecurityIssueHandler(AnswerDelegate onAnswer) : base(onAnswer)
        {
        }

        public override void HandleQuestion()
        {
            var answer = OnAnswer("Do you have security issue?");
            if (answer == Enums.Answer.No)
            {
                if (next != null)
                {
                    next.HandleQuestion();
                }
                else
                {
                    startingHandler.HandleQuestion();
                }
            }
        }
    }
}
