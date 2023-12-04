using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternProject
{
    public class YellowAfterGreenState : ITrafficLightState
    {
        public void PerformAction(TrafficLight trafficLight)
        {
            // Output the current state and perform the action associated with this state
            Console.WriteLine($"Current state: {GetType().Name}");
            Console.WriteLine("Traffic light is Yellow");
            Console.WriteLine("Traffic light is changing");

            // Added an empty line 
            Console.WriteLine();
        }

        public ITrafficLightState GetNextState()
        {
            // Return the next state, which is RedState, as this is the transition after YellowAfterGreenState
            return new RedState();
        }

        public string GetStateName()
        {
            return "YellowAfterGreenState";
        }
    }
}
