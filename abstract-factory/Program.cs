using System;
using abstract_factory.Archers;
using abstract_factory.Healers;

namespace abstract_factory
{
    public static class Program
    {
        public static void Main()
        {
            PlayerFactory archerFactory = new ArcherFactory();
            var archerClient = new Client(archerFactory);
            archerClient.Run();

            PlayerFactory healerFactory = new HealerFactory();
            var healerClient = new Client(healerFactory);
            healerClient.Run();

            Console.ReadKey();
        }
    }
}
