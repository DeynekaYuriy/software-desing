using DesignPatterns.Mediator;
using lab_6.CoR;
using lab_6.CoR.Handlers;
using lab_6.Mediator.AirTrafficControl;
using static lab_6.CoR.Enums;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1. CoR");
        var billingIssueHandler = new BillingIssueHandler(AnswerQuestion);
        var orderIssueHandler = new OrderIssueHandler(AnswerQuestion);
        var technicalIssueHandler = new TechnicalIssueHandler(AnswerQuestion);
        var securityIssueHandler = new SecurityIssueHandler(AnswerQuestion);
        billingIssueHandler.SetNext(orderIssueHandler).SetNext(technicalIssueHandler).SetNext(securityIssueHandler);
        billingIssueHandler.HandleQuestion();
        Console.WriteLine("2. Mediator");
        var boeing = new Aircraft("Boeing");
        var runways = new Dictionary<Runway, Aviation?>
        {
            { new Runway(), null },
            { new Runway(), null },
        };
        var commandCentre = new CommandCentre(runways);
        boeing.Land(commandCentre);
        boeing.TakeOff();

    }
    public static Answer AnswerQuestion(string question)
    {
        do
        {
            Console.WriteLine(question + " (Y/N)");
            var ch = Console.ReadKey();
            Console.WriteLine();
            if (ch.Key == ConsoleKey.Y)
            {
                return Answer.Yes;
            }
            else if (ch.Key == ConsoleKey.N)
            {
                return Answer.No;
            }

        } while (true);
    }
}