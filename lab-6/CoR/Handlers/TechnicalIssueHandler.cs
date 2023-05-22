using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6.CoR.Handlers
{
    public class TechnicalIssueHandler : SupportHandler
    {
        public TechnicalIssueHandler(AnswerDelegate onAnswer) : base(onAnswer)
        {
        }

        public override void HandleQuestion()
        {
            var answer = OnAnswer("Do you have technical issues?");
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
