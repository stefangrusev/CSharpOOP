namespace MilitaryElite
{
    using MilitaryElite.Core;
    using MilitaryElite.Core.Interfaces;
    using MilitaryElite.IO;
    using MilitaryElite.IO.Interfaces;
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IEngine engine = new Engine(reader, writer);

            engine.Run();
        }
    }
}
