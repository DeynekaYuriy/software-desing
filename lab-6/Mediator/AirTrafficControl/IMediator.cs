using DesignPatterns.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_6.Mediator.AirTrafficControl
{
    public interface IMediator
    {
        public void Notify(Aviation sender, RunwayEvent e);
    }
}
