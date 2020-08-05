using ConsoleApp1;
using NUnit.Framework;

namespace Bikes.Tests
{
    public class Tests
    {
        BikesList bikesList1 = new BikesList();
        BikesList bikesList2 = new BikesList();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetBikeInTurn_ShouldReturnCorrectBikeID()
        {
            string result;
            for (int i = 1; i < 5; i++)
            {
                result = bikesList1.GetBikeInTurn();
                var expected = "Bike-0" + i;
                Assert.AreEqual(expected, result);
            }
        }

        [Test]
        public void GetBikeInTurn_WhenCallsExceedTotalBikes_ShouldRotate()
        {
            string result;

            //Arr
            for (int i = 1; i < 5; i++)
            {
                result = bikesList1.GetBikeInTurn();
            }

            //Act
            result = bikesList1.GetBikeInTurn();
            var expected = "Bike-01";

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}