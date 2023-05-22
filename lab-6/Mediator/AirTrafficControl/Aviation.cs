using DesignPatterns.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6.Mediator.AirTrafficControl
{
    public abstract class Aviation
    {
        public string Name { get; set; }
        public bool IsTakingOff { get; set; }

        public CommandCentre? currentCommandCentre;
        public Aviation(string name)
        {
            Name = name;
        }
        public void Land(CommandCentre commandCentre)
        {
            commandCentre.Notify(this, RunwayEvent.OnLandRequest);
        }
        public void TakeOff()
        {
            currentCommandCentre?.Notify(this, RunwayEvent.OnFreedUp);
        }
    }
}
