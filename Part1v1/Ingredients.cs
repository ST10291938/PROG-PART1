using System;


namespace Part1v1
{// Ingredients class encapsulates the methods and details about the ingredients
    class Ingredients
    {//pprivate fields to store each detail abot the ingredient
        private String name;
        private String measurements;
        private double quantity;
        private double originalQuantity;
       
        //Getters and setters for the ingriendient details
        public string Name { get => name; set => name = value; }
        public string Measurements { get => measurements; set => measurements = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public double OriginalQuantity { get => originalQuantity; }

        //Constructors to intialize a new instance of an ingriendient
        public Ingredients(string name, string measurements, double quantity) {

            this.name = name;
           this.measurements = measurements;
            this.originalQuantity = quantity; 
            this.quantity = quantity;

        }

        public Ingredients(string? name, double quantity, string? measurement)
        {
            this.name = name;
            this.quantity = quantity;
            this.measurements = measurement;
        }
    }
}
