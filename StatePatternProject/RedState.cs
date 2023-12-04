using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternProject
{
    public class RedState : ITrafficLightState
    {
        // This method is called when the traffic light is in the Red state
        public void PerformAction(TrafficLight trafficLight)
        {
            // Printed the current state and information about the red state
            Console.WriteLine($"Current state: {GetType().Name}");
            Console.WriteLine("Traffic light is Red");
            Console.WriteLine("Traffic light is changing");

            // Added an empty line for spacing
            Console.WriteLine();
        }

        // This method returns the next state after the Red state
        public ITrafficLightState GetNextState()
        {
            // In this example, transitioning to YellowAfterRedState after RedState
            return new YellowAfterRedState();
        }

        public string GetStateName()
        {
            return "RedState";
        }
    }
}
