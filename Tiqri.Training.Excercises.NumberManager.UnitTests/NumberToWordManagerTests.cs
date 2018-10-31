using System.Collections.Generic;
using NUnit.Framework;

namespace Tiqri.Training.Excercises.NumberManager.UnitTests
{
    [TestFixture]
    public class NumberToWordManagerTests
    {
        private INumberToWordManager _sut;


        [SetUp]
        public void Setup()
        {
            _sut = new NumberToWordManager();
        }

        [Test]
        public void OnConvert_WhenValidNumberListProvided_ShouldReturnsNumbersAsWords()
        {
            // arrange
            List<int> numbers = new List<int> { 1, 2, 3 };

            // Act
            var result = _sut.Convert(numbers);

            // Assert
            Assert.AreEqual(result.Count,3);
        }
    }
}
