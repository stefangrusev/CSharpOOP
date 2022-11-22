using System;
using System.Collections.Generic;
namespace _04.PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;


        private Dictionary<string, double> flourTypes = new Dictionary<string, double>
        {
            { "white", 1.5 },
            {"wholegrain", 1 },
        };
        private Dictionary<string, double> bakingTechniques = new Dictionary<string, double>
        {
            {"crispy", 0.9 },
            {"chewy", 1.1 },
            {"homemade", 1 },
        };
        public Dough(string flourType, string bakingTechnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType
        {
            get => flourType;
            private set
            {
                if (!this.flourTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => bakingTechnique;
            private set
            {
                if (!bakingTechniques.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }

        public int Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }
        public double CaloriesPerGram => (2 * this.Weight) * this.flourTypes[this.FlourType.ToLower()] * this.bakingTechniques[this.BakingTechnique.ToLower()];
    }
}
