using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1v1
{
   class Ingredients
    {
        private String name;
        private String measurements;
        private double quantity;
       

        public string Name { get => name; set => name = value; }
        public string Measurements { get => measurements; set => measurements = value; }
        public double Quantity { get => quantity; set => quantity = value; }

        //Constructor
        public Ingredients(string name, string measurements, double quantity) {

            name = Name;
            measurements = Measurements;
            quantity = Quantity;
                }

        public Ingredients(string? name, double quantity, string? measurement)
        {
            this.name = name;
            this.quantity = quantity;
            this.measurements = measurement;
        }
    }
}
