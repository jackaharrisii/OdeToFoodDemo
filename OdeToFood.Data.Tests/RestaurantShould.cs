using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OdeToFood.Data.Models;

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

        Restaurant DetailsTest = new Restaurant(1, "Bob's Burgers", CuisineType.Italian);

        [Fact]
        public void RestaurantConstructor_WithNoValues_ShouldBuild()
        {
            //Arrange
            int ExpectedId = 0;
            string ExpectedName = "None";
            CuisineType ExpectedCuisine = CuisineType.None;
            //Act
            Restaurant Test = new Restaurant();
            //Assert
            Assert.Equal(ExpectedId, Test.Id);
            Assert.Equal(ExpectedName, Test.Name);
            Assert.Equal(ExpectedCuisine, Test.Cuisine);
        }

        [Fact]
        public void RestaurantConstructor_WithValues_ShouldBuild()
        {
            //Arrange
            int ExpectedId = 0;
            string ExpectedName = "None";
            CuisineType ExpectedCuisine = CuisineType.None;
            //Act
            Restaurant Test = new Restaurant(ExpectedId, ExpectedName, ExpectedCuisine);
            //Assert
            Assert.Equal(ExpectedId, Test.Id);
            Assert.Equal(ExpectedName, Test.Name);
            Assert.Equal(ExpectedCuisine, Test.Cuisine);
        }

        [Fact]
        public void RestaurandGetAndSet_NewValues_ShouldEqual()
        {
            //Arrange
            int ExpectedId = 1;
            string ExpectedName = "Innsmouth Fine Cuisine";
            CuisineType ExpectedCuisine = CuisineType.Other;
            //Act
            Restaurant Test = new Restaurant();
            Test.Id = ExpectedId;
            Test.Name = ExpectedName;
            Test.Cuisine = ExpectedCuisine;
            //Assert
            Assert.Equal(ExpectedId, Test.Id);
            Assert.Equal(ExpectedName, Test.Name);
            Assert.Equal(ExpectedCuisine, Test.Cuisine);
        }

    }
}
