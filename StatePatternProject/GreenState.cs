using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternProject
{
    public class GreenState : ITrafficLightState 
    {
        public void PerformAction(TrafficLight trafficLight)
        {
            // Implement behavior for the green state
            Console.WriteLine("Traffic light is green");

            // Transition to the next state if needed
            trafficLight.TransitionTo(new YellowState());  // For simplicity, transitioning to YellowState after GreenState
        }
    }
}
