using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(5, 5, 5, 15)]
        [InlineData(6, 9, 11, 26)]
        [InlineData(-2, 2, 9, 9)]
        [InlineData(null, null, null, null)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
/*
 *  Hi Miah!
 *  
 *  I can not get this code to run. I think it's because my Visual Studio is unable to create
 *  a reference to the main project from the testing project. I tried to do a manual
 *  reference but I didn't know what I was doing so that didn't work. Basically my code doesn't recognize
 *  the Calculator class so when I attempt to make a new variable test, it breaks.
 *  
 *  Please let me know if you are able to get this code to run, which would indicate that my issue is with
 *  the project dependencies and references. I tend to steer clear of make files and compile headaches, which
 *  means I know nothing. 
 * 
 * */



            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            var test = new Calculator();                 

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = test.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null, null, null)]//Add test data <-------
        [InlineData(3, 1, 2)]
        [InlineData(101, 2, 99)]
        [InlineData(-2, 5, -7)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null, null, null)]//Add test data <-------
        [InlineData(2, 3, 6)]
        [InlineData(9, 9, 81)]
        [InlineData(4, -3, -12)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 0, 0)]//Add test data <-------
        [InlineData(4, 2, 2)]
        [InlineData(27, 3, 9)]
        [InlineData(-64, 16, -4)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual );
        }

    }
}
