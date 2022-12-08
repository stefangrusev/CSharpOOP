namespace Stealer
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy currentSpy = new Spy();
            string result = currentSpy.CollectGettersAndSetters("Stealer.Hacker");

            Console.WriteLine(result);
        }
    }
}