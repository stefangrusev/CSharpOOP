using System;
namespace _01.ClassBoxData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var box = new Box(length, width, height);

            if (box.Length > 0 && box.Width > 0 && box.Height > 0)
            {
                Console.WriteLine($"Surface Area - {box.CalculateSurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralSurfaceArea():f2}");
                Console.WriteLine($"Volume - {box.Volume():f2}");
            }
        }
    }
}
