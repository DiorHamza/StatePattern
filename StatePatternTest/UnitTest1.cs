using StatePatternProject;

namespace StatePatternTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Add any setup code if needed
        }

        [Test]
        public void TestInitialStateIsRed()
        {
            // Arrange
            var trafficLight = new TrafficLight(new RedState());

            // Act
            trafficLight.ChangeState();

            // Assert
            Assert.AreEqual("Traffic light is green", GetConsoleOutput(trafficLight.ChangeState));
        }

        [Test]
        public void TestTrafficLightStateTransition()
        {
            // Arrange
            var trafficLight = new TrafficLight(new RedState());

            // Act
            trafficLight.ChangeState();

            // Assert
            Assert.AreEqual("Traffic light is yellow", GetConsoleOutput(trafficLight.ChangeState));
        }

        [Test]
        public void TestTrafficLightCycle()
        {
            // Arrange
            var trafficLight = new TrafficLight(new RedState());

            // Act and Assert
            Assert.AreEqual("Traffic light is green", GetConsoleOutput(trafficLight.ChangeState));
            Assert.AreEqual("Traffic light is yellow", GetConsoleOutput(trafficLight.ChangeState));
            Assert.AreEqual("Traffic light is red", GetConsoleOutput(trafficLight.ChangeState));
        }

        [Test]
        public void TestMultipleCycles()
        {
            // Arrange
            var trafficLight = new TrafficLight(new RedState());

            // Act and Assert
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual("Traffic light is green", GetConsoleOutput(trafficLight.ChangeState));
                Assert.AreEqual("Traffic light is yellow", GetConsoleOutput(trafficLight.ChangeState));
                Assert.AreEqual("Traffic light is red", GetConsoleOutput(trafficLight.ChangeState));
            }
        }

        [Test]
        public void TestTransitionFromYellowToRed()
        {
            // Arrange
            var trafficLight = new TrafficLight(new YellowState());

            // Act and Assert
            Assert.AreEqual("Traffic light is red", GetConsoleOutput(trafficLight.ChangeState));
        }

        // Helper method to capture console output during testing
        private string GetConsoleOutput(Action action)
        {
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            action.Invoke();

            consoleOutput.Flush();
            return consoleOutput.ToString().Trim();
        }
    }

}