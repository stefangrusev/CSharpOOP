namespace SumOfIntegers
{
using System;

    internal class Program
    {
        private static int numbersSum;
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            foreach (var item in input)
            {
                try
                {
                    ProcessItem(item);
                }
                catch (FormatException )
                {
                    Console.WriteLine($"The element '{item}' is in wrong format!");
                }
                catch (OverflowException )
                {
                    Console.WriteLine($"The element '{item}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{item}' processed - current sum: {numbersSum}");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {numbersSum}");
        }

        private static void ProcessItem(string item)
        {
            var n = int.Parse(item);
            numbersSum += n;
        }
    }
}