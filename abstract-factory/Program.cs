using System;

namespace abstract_factory
{
    class Program
    {
        static void Main()
        {
            PlayerFactory factory1 = new ArcherFactory();
            Client client1 = new Client(factory1);
            client1.Run();

            PlayerFactory factory2 = new HealerFactory();
            Client client2 = new Client(factory2);
            client2.Run();

            Console.ReadKey();
        }
    }
}
