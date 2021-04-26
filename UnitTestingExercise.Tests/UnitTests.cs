using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(10,5,5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test1 = new UnitTestMethods();
            //Act
            var actual = test1.Subract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,2,6)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test2 = new UnitTestMethods();
            //Act
            var actual = test2.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6,2,3)]
        [InlineData(4,2,2)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test3 = new UnitTestMethods();
            //Act
            var actual = test3.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyName()
        {
            //Arrange
            
            var utm = new UnitTestMethods();

            //Act
            string actual = utm.MyName();
            //Assert
            Assert.Equal("Alexander Powalowski", actual);
        }

        [Fact]
        public void MyFavoriteFood()
        {
            //Arrange
            var utm = new UnitTestMethods();
            //Act
            string actual = utm.MyFavoriteFood();
            //Assert
            Assert.Equal("Spaghetti", actual);
        }
    }
}
