using System;
namespace _04.PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInput = Console.ReadLine().Split();
                string[] doughInput = Console.ReadLine().Split();
                var pizzaName = pizzaInput[1];
                var flourType = doughInput[1];
                var bakingTechnique = doughInput[2];
                var doughWeight = int.Parse(doughInput[3]);
                var pizza = new Pizza(pizzaName, new Dough(flourType, bakingTechnique, doughWeight));

                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    var inputArgs = input.Split();
                    var toppingType = inputArgs[1];
                    var toppingWeight = int.Parse(inputArgs[2]);
                    var currentTopping = new Topping(toppingType, toppingWeight);
                    pizza.AddTopping(currentTopping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
