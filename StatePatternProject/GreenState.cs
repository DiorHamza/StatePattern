using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternProject
{
    public class GreenState : ITrafficLightState
    {
        // This method is called when the traffic light is in the Green state
        public void PerformAction(TrafficLight trafficLight)
        {
            // Printed the current state and information about the green state
            Console.WriteLine($"Current state: {GetType().Name}");
            Console.WriteLine("Traffic light is Green");
            Console.WriteLine("Traffic light is Changing");

            // Added an empty line for spacing
            Console.WriteLine();
        }

        // This method returns the next state after the Green state
        public ITrafficLightState GetNextState()
        {
            // In this example, transitioning to YellowAfterGreenState after GreenState
            return new YellowAfterGreenState();
        }

        public string GetStateName()
        {
            return "GreenState";
        }
    }
}
