namespace SquareRoot
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var n = int.Parse(Console.ReadLine());
                if (n < 0)
                    throw new ArgumentException("Invalid number.");
                Console.WriteLine(Math.Sqrt(n));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}