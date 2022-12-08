namespace Collector
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            Spy spy = new Spy();
            var result = spy.AnalyzeAccessModifiers("Stealer.Hacker");

            Console.WriteLine(result);
        }
    }
}