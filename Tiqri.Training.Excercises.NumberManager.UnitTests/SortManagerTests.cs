using System.Collections.Generic;
using Moq;
using NUnit.Framework;

namespace Tiqri.Training.Excercises.NumberManager.UnitTests
{
    [TestFixture]
    public class SortManagerTests
    {
        private ISortManager _sut;
        private Mock<IFileManager> _mockFileManager;


        [SetUp]
        public void SetUp()
        {
            _mockFileManager = new Mock<IFileManager>();

            _sut = new SortManager(_mockFileManager.Object);
        }

        [Test]
        public void OnSort_WhenValidNumberListProvided_ShouldReturnsIntegerList()
        {
            // Arrange
            var numbers = new List<string> {"3", "2", "1"};
            _mockFileManager.Setup(c => c.ReadCsvFile(It.IsAny<string>())).Returns(numbers);

            // Act
            var result = _sut.Sort("numbers.csv");

            // Assert
            Assert.AreEqual(result.Count, 3,"1. list count");
            Assert.AreEqual(result[0], 1);
            Assert.AreEqual(result[1], 2);
            Assert.AreEqual(result[2], 3);
        }       
    }
}
