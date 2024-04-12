using System;


namespace Part1v1

    // A class Recipe to encapsulate all the methods for the recipe class
{
     class Recipe
    { //Properties of the class Recipe 
        public Ingredients[] Ingredients { get; set; }
        public string recipeName { get; set; }
        public MyCookingMethod[] CookingMethods { get; set; }

        //Constructors
        public Recipe(string name, int ingredientCount, int stepCount) {
        
            recipeName = name;
            Ingredients = new Ingredients[ingredientCount];
            CookingMethods = new MyCookingMethod[stepCount];
        }

        public void ScaleRecipe(double factor)
        { //method that will scale the quantity of the ingredients by a given factor
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void DisplayRecipe()
        {//method that will display the ingredients and their cooking methods
            Console.WriteLine("\nIngredients: ");
            foreach(var ingredient in Ingredients) // for each loop that will loop through the ingredients
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Measurements} {ingredient.Name}");

            }
            Console.WriteLine("\nCooking Methods");
            int methodNumber = 1;
            foreach (var method in CookingMethods)
            {
                Console.WriteLine($"{methodNumber++}.{method.GetDescription()}");
            }
        }

        public void DeleteData()
        {//this method will confirm and delete all the recipe data
            Console.WriteLine("Confirm if you want to delete all recipe data? (YES/NO)");
            string UserResponse = Console.ReadLine().ToUpper().Trim();

            if (UserResponse == "yes")
            {
                // this clears theingredients array
                Ingredients[] myIngredients = new Ingredients[0];

                // this clears the cooking method/steps array
                MyCookingMethod[] myCookingMethod = new MyCookingMethod[0];

                // this clears the information on the console
                Console.Clear();


            }
            else
            {
                Console.WriteLine("Recipe data successfully cleared.");

               
            }
        }

        public void ResetValues()
        {//method that will revert the quantities back to the original value
            foreach(var ingredients in Ingredients)
            {
                ingredients.Quantity = ingredients.OriginalQuantity;
            }
        }
    }
}
