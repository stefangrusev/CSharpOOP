﻿namespace Stealer
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            Spy spy = new Spy();
            var result = spy.RevealPrivateMethods("Stealer.Hacker");

            Console.WriteLine(result);
        }
    }
}