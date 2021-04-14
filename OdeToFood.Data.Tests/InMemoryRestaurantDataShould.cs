using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OdeToFood.Data.Tests
{
    public class InMemoryRestaurantDataShould
    {

        [Fact]
        public void RestaurandGetAndSet_NewValues_ShouldEqual()
        {
            //Arrange
            InMemoryRestaurantData test = new InMemoryRestaurantData();
            Restaurant ExpectedFirst = new Restaurant(3, "Mango Grove", CuisineType.Indian);
            Restaurant ExpectedSecond = new Restaurant(1, "Scott's Pizza", CuisineType.Italian);
            Restaurant ExpectedThird = new Restaurant(2, "Tersiguels", CuisineType.French);
            //Act
            List<Restaurant> Actual = new List<Restaurant>(test.GetAll());
            //Assert
            Assert.Equal(ExpectedFirst.Name, Actual[0].Name);
            Assert.Equal(ExpectedSecond.Name, Actual[1].Name);
            Assert.Equal(ExpectedThird.Name, Actual[2].Name);
        }

    }
}
