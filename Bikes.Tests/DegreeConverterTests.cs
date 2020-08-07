using NUnit.Framework;

namespace ConsoleApp1.Tests
{
    [TestFixture]
    class DegreeConverterTests
    {
        [TestCase(0, 32)]
        [TestCase(5, 41)]
        public void ConvertToFahrenheit_GivenACelsiusDegree_ShouldReturnExpectedFahrenheit(double celsius, double expected)
        {
            //Arr

            //Act
            var result = DegreeConverter.ConvertToFahrenheit(celsius);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(32, 0)]
        [TestCase(41, 5)]
        public void ConvertToCelsius_GivenAFahrenheitDegree_ShouldReturnExpectedCelsius(double fahrenheit, double expected)
        {
            //Arr

            //Act
            var result = DegreeConverter.ConvertToCelsius(fahrenheit);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
