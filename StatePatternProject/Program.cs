using StatePatternProject;

class Program
{
    static void Main(string[] args)
    {
        // Created a traffic light with an initial state of RedState
        var trafficLight = new TrafficLight(new RedState());

        // Looped through state changes (for simplicity, 10 iterations)
        for (int i = 0; i < 10; i++)
        {
            // Called the ChangeState method to transition to the next state
            trafficLight.ChangeState();
        }
    }
}

