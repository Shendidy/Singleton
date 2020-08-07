using NUnit.Framework;

namespace ConsoleApp1.Tests
{
    [TestFixture]
    public class BikesListTests
    {
        static BikesList counter1 = BikesList.GetBikesList();
        static BikesList counter2 = BikesList.GetBikesList();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetBikeInTurn_ShouldReturnCorrectBikeID()
        {
            //Arr
            string result;
            while (true)
            {
                if (counter1.GetBikeInTurnIndex() == 0) break;
                counter1.GetBikeInTurn();
            }

            for (int i = 1; i < 5; i++)
            {
                //Act
                result = counter1.GetBikeInTurn();
                var expected = "Bike-0" + i;

                //Assert
                Assert.AreEqual(expected, result);
            }
        }

        [Test]
        public void GetBikeInTurn_WhenCallsExceedTotalBikes_ShouldRotate()
        {
            //Arr
            while (true)
            {
                if (counter1.GetBikeInTurnIndex() == 0) break;
                counter1.GetBikeInTurn();
            }

            string result;

            for (int i = 1; i < 5; i++)
            {
                result = counter1.GetBikeInTurn();
            }

            //Act
            result = counter1.GetBikeInTurn();
            var expected = "Bike-01";

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetBikeInTurn_WhenMoreThanOneCounter_ShouldUseTheSameBikesList()
        {
            //Arr
            while (true)
            {
                if (counter1.GetBikeInTurnIndex() == 0) break;
                counter1.GetBikeInTurn();
            }

            //Act
            var result1 = counter1.GetBikeInTurn();
            var result2 = counter2.GetBikeInTurn();

            //Assert
            Assert.AreEqual("Bike-01", result1);
            Assert.AreEqual("Bike-02", result2);
        }
    }
}