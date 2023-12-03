using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternProject
{
    public class RedState : ITrafficLightState
    {
        public void PerformAction(TrafficLight trafficLight)
        {
            // Implement behavior for the red state
            Console.WriteLine("Traffic light is red");

            // Transition to the next state if needed
            trafficLight.TransitionTo(new GreenState());
        }
    }
}
