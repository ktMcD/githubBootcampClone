using Xunit;
using LearningUnitTest;
using System;

namespace LearingUnitTest.Tests
{
    public class ArithmeticTests
    {
    

       public void SetHappyPath()
        {
            _subject = new Arithmetic();
        }

        Arithmetic _subject;

        [Theory]
        [InlineData(2,3,5)]
        [InlineData(-11, 13, 2)]
        [InlineData(0, 0, 0)]
        [InlineData(-2,-3,-5)]     
        public void SumMethod_WhenGivenTwoIntegers_WillReturnTheSumOfThoseNumbers(int valueOne, int valueTwo, int expectedResult)
        {

            // Arrange - Setup the SUT and any other other objects
           // Arithmetic sut = new Arithmetic();

            // Act - Call the method thats being tested
            int result = _subject.Sum(valueOne, valueTwo);

            // Assert - Comparing the result of the ACT with your expected outcome
            Assert.Equal(expectedResult,result);
        }


        [Fact]
        public void SumMethod_WhenGivenTwoIntegers_WillReturnTheSumOfThoseNumbers_Fact()
        {
            // Arrange - Setup the SUT and any other other objects
            Arithmetic sut = new Arithmetic();

            // Act - Call the method thats being tested
            int result = sut.Sum(2, 3);

            // Assert - Comparing the result of the ACT with your expected outcome
            Assert.Equal(5, result);
        }

        [Fact]
        public void SumMethod_WhenGivenIntegerArray_WillReturnTheSumOfAllNumbers()
        {
            // Arrange - Setup the SUT and any other other objects
            Arithmetic sut = new Arithmetic();
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Act - Call the method thats being tested
            int result = sut.Sum(numbers);

            // Assert - Comparing the result of the ACT with your expected outcome
            Assert.Equal(14,result);

        }

        [Fact]
        public void SumMethod_WhenGivenAnEmptyArray_ReturnsZero()
        {
            // Arrange
            Arithmetic sut = new Arithmetic();
            int[] numbers = new int[0];

            // Act - Call the method thats being tested
            int result = sut.Sum(numbers);

            // Assert - Comparing the result of the ACT with your expected outcome
            Assert.Equal(0,result);
        }


        [Fact]
        public void DivideMethod_WhenZeroIsSecondNumber_ReturnsNegativeOne()
        {
            // Arrange
            Arithmetic sut = new Arithmetic();

            // Act - Call the method thats being tested
            int result = sut.Divide(4, 0);

            // Act & Assert
            Assert.Equal(-1,result);
        }

        /*        


      [Fact]
      public void DivideMethod_WhenZeroIsSecondNumber_ThrowsException()
      {
          // Arrange
          Arithmetic sut = new Arithmetic();

          // Act & Assert
          Assert.Throws<DivideByZeroException>(() => sut.Divide(4, 0));
      }




      [Fact]
      public void SumMethod_WhenGivenThreeNumbers_WillReturnTheSumOfThoseNumbers()
      {
          // Arrange - Setup the SUT and any other other objects
          LearningTestSamples sut = new LearningTestSamples();

          // Act - Call the method thats being tested

          // Assert - Comparing the result of the ACT with your expected outcome



      }



      */
    }
}