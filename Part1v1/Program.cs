﻿using System;


namespace Part1v1
{
    class Program
    {

        static void Ingredients()
        {
            Console.WriteLine("\nHow many ingredients does your recipe have? ");
            int numOfIngredients = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            Ingredients[] ingredients = new Ingredients[numOfIngredients];

            for (int i = 0; i < numOfIngredients; i++)
            {
                Console.WriteLine($"Ingredient {i + 1}");
                string name = Console.ReadLine();
                Console.Write("\n");

                Console.Write($"Enter measurements {i + 1} \n");
                string measurements = Console.ReadLine();
                Console.Write("\n");


                Console.WriteLine($"Enter quantity {i + 1}");
                double quantity = Convert.ToDouble(Console.ReadLine());

                ingredients[i] = new Ingredients(name, quantity, measurements);

                Console.WriteLine();

            }

            Console.WriteLine("Your ingredients are: ");
            foreach (Ingredients ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Measurements} of {ingredient.Name}");

            }

        }



        static void Main(string[] args)
        {

            Console.WriteLine("Hello! Welcome to your recipe application:");
            Console.WriteLine("Please enter a name for your recipe:");
            String recipeName = Console.ReadLine().ToUpper().Trim();
            Console.Write("\n" + recipeName);




            Console.WriteLine("\nHow many ingredients does your recipe require? ");
            int numOfIngredients = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine("How many steps/methods does your recipe require? ");
            int numOfSteps = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            Recipe recipe = new Recipe(recipeName, numOfIngredients, numOfSteps);

            for (int i = 0; i < numOfIngredients; i++)
            {
                Console.WriteLine($"Ingredient {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write("\n");

                Console.Write($"Enter measurements {i + 1} (e.g, cups, tablespoon, teaspoon...): \n");
                string measurements = Console.ReadLine();
                Console.Write("\n");


                Console.WriteLine($"Enter quantity {i + 1} (number only): ");
                double quantity = Convert.ToDouble(Console.ReadLine());

                recipe.Ingredients[i] = new Ingredients(name, quantity, measurements);

                Console.WriteLine();

            }

            for (int i = 0; i < numOfSteps; i++)
            {
                Console.WriteLine($"Enter description of step {i + 1}: ");
                string description = Console.ReadLine();
                Console.Write("\n");

                recipe.CookingMethods[i] = new MyCookingMethod(description);

            }
            Console.WriteLine("*************************************************************************************************************************");
            Console.WriteLine($"RECIPE FOR: {recipeName}");
            recipe.DisplayRecipe();


            Console.WriteLine("\n");
            bool SelectOption = true;

            while (SelectOption)
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Please choose one of the following options to continue: \n");
                Console.WriteLine("1. Scale ingredients to factor(0.5 for half, 2 for double, 3 for triple)" + ("\n") +
                    "2. Clear/Delete Data" + ("\n") + "3. Reset to original factors\n" + "4.Exit\n");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");



                int option = Convert.ToInt32((Console.ReadLine()));

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the scaling factor: ");
                        double factor = double.Parse(Console.ReadLine());
                        recipe.ScaleRecipe(factor);
                        Console.WriteLine("\nScaled Recipe Details: \n");
                        recipe.DisplayRecipe();
                        break;

                    case 2:
                        recipe.DeleteData();
                        Console.WriteLine("Recipe data cleared");
                        break;

                    case 3:
                        Console.WriteLine("Recipe reverted back to original values:");
                        Console.WriteLine("\n");
                        recipe.ResetValues();
                        recipe.DisplayRecipe();
                        break;

                        case 4:
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Invalid option selected, insert valid option.");
                        break;
                }


              
            }
        }
        private static void CookingMethods()
        {
            Console.WriteLine("How many steps does your recipe require? ");
            int numOfSteps = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            MyCookingMethod[] cookingMethods = new MyCookingMethod[numOfSteps];

            for (int i = 0; i < numOfSteps; i++)
            {
                Console.WriteLine($"Enter description of step {i + 1}: ");
                string description = Console.ReadLine();
                Console.Write("\n");

                cookingMethods[i] = new MyCookingMethod(description);
            }

            Console.WriteLine("Your cooking method is as follows:");
            foreach (MyCookingMethod cookingMethod in cookingMethods)
            {
                Console.Write($"{cookingMethod.GetDescription()}\n");
            }
        }
    }
}

