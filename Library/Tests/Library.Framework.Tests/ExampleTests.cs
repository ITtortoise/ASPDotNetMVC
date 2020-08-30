using NUnit.Framework;

namespace Library.Framework.Tests
{
    public class ExampleTests
    {
        [SetUp]
        public void Setup()
        {

        }

        //[Test]
        //public void Sum_PositiVevalue_ReturnsCorrectSum()
        //{
        //    //Arrange 
        //    int a = 10;
        //    int b = 3;
        //    var example = new Example();
        //    var expectedResult = 13;

        //    //Act
        //    var result = example.Sum(a, b);

        //    //Assert
        //    Assert.AreEqual(expectedResult,result);

        //}
        [Test]
        [TestCase(12,2,14)]
        public void Sum_PositiVevalue_ReturnsCorrectSum(int a ,int b,int expectedResult)
        {
            //Arrange 
            var example = new Example();

            //Act
            var result = example.Sum(a, b);

            //Assert
            Assert.AreEqual(expectedResult, result);

        }
    }
}