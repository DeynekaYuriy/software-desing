using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_6.CoR.Handlers
{
    public class OrderIssueHandler : SupportHandler
    {
        public OrderIssueHandler(AnswerDelegate onAnswer) : base(onAnswer)
        {
        }

        public override void HandleQuestion()
        {
            var answer = OnAnswer("Do you have problems with your order?");
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
