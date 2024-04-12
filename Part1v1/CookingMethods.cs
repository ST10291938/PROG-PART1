using System;


namespace Part1v1
{
    // class MyCookingMethod that encapsulate all the methods for each cooking method
    class MyCookingMethod
    {//private field to store each description
        private string description;

        public string GetDescription()
        {//this method will retrieve the description inserted by the user and return it back to the console
            return description;
        }

        public void SetDescription(string value)
        {// this method sets/updates the inserted description
            description = value;      //contains the the value of each cooking method
        }

        public MyCookingMethod(string description) {

            SetDescription(description);
        }
    }
}
