using StatePatternProject;

namespace StatePatternTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestInitialStateIsRed()
        {
            // Arrange
            var trafficLight = new TrafficLight(new RedState());

            // Act & Assert
            Assert.AreEqual("RedState", trafficLight.GetCurrentStateName());
        }

        [Test]
        public void TestTransitionFromRedToYellow()
        {
            // Arrange
            var trafficLight = new TrafficLight(new RedState());

            // Act
            trafficLight.ChangeState();

            // Assert
            Assert.AreEqual("YellowAfterRedState", trafficLight.GetCurrentStateName());
        }

        [Test]
        public void TestTransitionFromYellowToGreen()
        {
            // Arrange
            var trafficLight = new TrafficLight(new YellowAfterRedState());

            // Act
            trafficLight.ChangeState();

            // Assert
            Assert.AreEqual("GreenState", trafficLight.GetCurrentStateName());
        }

        [Test]
        public void TestMultipleStateChanges()
        {
            // Arrange
            var trafficLight = new TrafficLight(new RedState());

            // Act
            trafficLight.ChangeState();
            trafficLight.ChangeState();
            trafficLight.ChangeState();

            // Assert
            Assert.AreEqual("YellowAfterGreenState", trafficLight.GetCurrentStateName());
        }

        [Test]
        public void TestTransitionLoop()
        {
            // Arrange
            var trafficLight = new TrafficLight(new GreenState());

            // Act
            trafficLight.ChangeState();
            trafficLight.ChangeState();
            trafficLight.ChangeState();
            trafficLight.ChangeState();

            // Assert
            Assert.AreEqual("GreenState", trafficLight.GetCurrentStateName());
        }
    }





    }

