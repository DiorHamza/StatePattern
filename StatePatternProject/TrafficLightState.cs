using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternProject
{
    public interface ITrafficLightState
    {
        // This method is called to perform an action associated with the current state
        void PerformAction(TrafficLight trafficLight);

        // This method returns the next state in the traffic light system
        ITrafficLightState GetNextState();

        string GetStateName(); 
    }
}
