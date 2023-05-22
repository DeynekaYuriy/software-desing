using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab_6.CoR.Enums;

namespace lab_6.CoR
{

    public abstract class SupportHandler : IHandler
    {
        protected static SupportHandler startingHandler = null;
        protected IHandler? next;
        public delegate Answer AnswerDelegate(string message);
        public AnswerDelegate OnAnswer;

        public SupportHandler(AnswerDelegate onAnswer)
        {
            if (startingHandler == null)
            {
                startingHandler = this;
            }
            OnAnswer = onAnswer;
        }
        public abstract void HandleQuestion();

        public IHandler SetNext(IHandler handler)
        {
            next = handler;
            return handler;
        }
    }
}
