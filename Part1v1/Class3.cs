using System;


namespace Part1v1
{
     class Recipe
    {
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
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("\nIngredients: ");
            foreach(var ingredient in Ingredients)
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
    }
}
