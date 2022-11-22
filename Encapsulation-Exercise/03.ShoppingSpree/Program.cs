using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var inputPeople = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                var people = new List<Person>();

                for (int i = 0; i < inputPeople.Length; i++)
                {
                    var personInfo = inputPeople[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                    var name = personInfo[0];
                    var money = decimal.Parse(personInfo[1]);
                    people.Add(new Person(name, money));

                }

                var inputProducts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                var products = new List<Product>();

                for (int i = 0; i < inputProducts.Length; i++)
                {
                    var productInfo = inputProducts[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                    var name = productInfo[0];
                    var cost = decimal.Parse(productInfo[1]);
                    products.Add(new Product(name, cost));
                }

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    var commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    var currentPerson = people.FirstOrDefault(p => p.Name == commandArgs[0]);
                    var currentProduct = products.FirstOrDefault(p => p.Name == commandArgs[1]);
                    Console.WriteLine(currentPerson.AddProduct(currentProduct));
                }
                people.ForEach(x => Console.WriteLine(x.Products.Count > 0 ? $"{x.Name} - {string.Join(", ", x.Products)}" : $"{x.Name} - Nothing bought"));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
