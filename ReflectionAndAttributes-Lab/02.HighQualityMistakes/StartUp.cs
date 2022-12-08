namespace HighQualityMistakes
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            Spy spy = new Spy();
            string result = spy.AnalyzeAccessModifiers("Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}