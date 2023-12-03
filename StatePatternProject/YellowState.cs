using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternProject
{
    public class YellowState : ITrafficLightState
    {
        public void PerformAction(TrafficLight trafficLight)
        {
            // Implement behavior for the yellow state
            Console.WriteLine("Traffic light is yellow");

            // Transition to the next state if needed
            trafficLight.TransitionTo(new RedState());  // For simplicity, transitioning to RedState after YellowState
        }
    }
}
