using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarsTheLast.Models
{
    public class Car
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal PriceSell { get; set; }

        public decimal? Salary { get; set; }
        public override string ToString()
        {
            return $"{Name}-{Price}$";
        }
    }
}
