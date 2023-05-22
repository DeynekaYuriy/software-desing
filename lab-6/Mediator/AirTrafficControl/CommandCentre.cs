using lab_6.Mediator.AirTrafficControl;

namespace DesignPatterns.Mediator
{
    public class CommandCentre : IMediator
    {
        private Dictionary<Runway, Aviation?> _runways = new();

        public CommandCentre(Dictionary<Runway, Aviation?> runways)
        {
            _runways = runways;
        }


        public void Notify(Aviation sender, RunwayEvent e)
        {
            switch (e)
            {
                case RunwayEvent.OnLandRequest:
                    {
                        var runway = _runways.Where(runway => runway.Value == null).FirstOrDefault().Key;
                        if (runway != null)
                        {
                            runway.IsBusyWithAircraft = true;
                            runway.HighLightRed();
                            _runways[runway] = sender;
                            sender.currentCommandCentre = this;
                        }
                        else
                        {
                            Console.WriteLine("There are no free runways!");
                        }
                        break;
                    }
                case RunwayEvent.OnFreedUp:
                    {
                        var runway = _runways.Where(runway => runway.Value == sender).FirstOrDefault().Key;
                        if (runway != null)
                        {
                            var aviation = _runways[runway];
                            _runways[runway] = null;
                            Console.WriteLine($"{aviation.Name} is taking off.");
                            runway.HighLightGreen();
                            Console.WriteLine($"{aviation.Name} has took off.");
                        }
                        break;
                    }

            }
        }
    }
}