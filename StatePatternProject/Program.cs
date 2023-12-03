using StatePatternProject;

class Program
{
    static void Main(string[] args)
    {
        // Create a traffic light with an initial state (e.g., RedState)
        var trafficLight = new TrafficLight(new RedState());

        // Change the state of the traffic light, and it will transition to the next state
        trafficLight.ChangeState();

        // Change the state of the traffic light again to simulate further stages
        trafficLight.ChangeState();
    }
}
