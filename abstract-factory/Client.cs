using System;

namespace abstract_factory
{
    /// <summary>
    /// The Client. Here, our objects are created and put to use
    /// </summary>
    internal class Client
    {
        private readonly string _playerFactoryName;
        private readonly Human _priya; 
        private readonly Human _olaf; 
        private readonly Elf _beleg;
        private readonly Elf _haldir;

        public Client(PlayerFactory playerFactory)
        {
            _playerFactoryName = playerFactory.GetType().Name;
            _priya = playerFactory.CreateHuman("Priya");
            _olaf = playerFactory.CreateHuman("Olaf");
            _beleg = playerFactory.CreateElf("Beleg");
            _haldir = playerFactory.CreateElf("Haldir");
        }

        internal void Run()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"-- Running Client for {this._playerFactoryName} --");
            _beleg.Interact(_olaf);
            _priya.Interact(_olaf);
            _olaf.Interact(_priya);
            _haldir.Interact(_beleg);
        }
    }
}