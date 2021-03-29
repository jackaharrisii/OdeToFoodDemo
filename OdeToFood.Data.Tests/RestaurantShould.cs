using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OdeToFood.Data.Tests
{
    public class RestaurantShould
    {

        [Fact]
        public void Doublethink_2plus2_equals5()  //UnitOfWork_InitialCondition_ExpectedResult
        {
            //Arrange
            int expected = 5;
            int actual = 2 + 2;
            //Act
            actual = Doublethink(actual);
            //Assert
            Assert.Equal(expected, actual);
        }

        public int Doublethink(int input)
        {
            return input + 1;
        }

    }
}
