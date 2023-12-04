using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternProject
{
    public class YellowAfterRedState : ITrafficLightState
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
            // Return the next state, which is GreenState, as this is the transition after YellowAfterRedState
            return new GreenState();
        }

        public string GetStateName()
        {
            return "YellowAfterRedState";
        }


    }
}
