using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }

        public Restaurant()
        {
            this.Id = 0;
            this.Name = "None";
            this.Cuisine = CuisineType.None;
        }

        public Restaurant(int id, string name, CuisineType cuisine)
        {
            this.Id = id;
            this.Name = name;
            this.Cuisine = cuisine;
        }

    }
}
