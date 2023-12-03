using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternProject
{
    public interface ITrafficLightState
    {
        void PerformAction(TrafficLight trafficLight);
    }
}
