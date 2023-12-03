using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternProject
{
    public class TrafficLight
    {
        private ITrafficLightState _state;

        public TrafficLight(ITrafficLightState initialState)
        {
            _state = initialState;
        }

        public void ChangeState()
        {
            _state.PerformAction(this);
        }

        public void TransitionTo(ITrafficLightState newState)
        {
            _state = newState;
        }
    }
}
