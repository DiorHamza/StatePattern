using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternProject
{
    public class TrafficLight
    {
        // Private field to store the current state of the traffic light
        private ITrafficLightState _currentState;

        // Constructor to initialize the traffic light with an initial state
        public TrafficLight(ITrafficLightState initialState)
        {
            _currentState = initialState;
        }

        // Method to change the state of the traffic light
        public void ChangeState()
        {
            // Perform the action associated with the current state
            _currentState.PerformAction(this);

            // Transition to the next state
            TransitionTo(_currentState.GetNextState());
        }

        // Method to transition to a new state
        public void TransitionTo(ITrafficLightState newState)
        {
            // Set the current state to the new state
            _currentState = newState;
        }

        public string GetCurrentStateName()
        {
            return _currentState.GetStateName();
        }
    }
}




