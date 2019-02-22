using System;

namespace abstract_factory
{
    /// <summary>
    /// The Client. Here, our objects are created and put to use
    /// </summary>
    internal class Client
    {
        private readonly Human _priya; 
        private readonly Human _olaf; 
        private readonly Elf _beleg;

        public Client(PlayerFactory playerFactory)
        {
            _priya = playerFactory.CreateHuman("Priya");
            _olaf = playerFactory.CreateHuman("Olaf");
            _beleg = playerFactory.CreateElf("Beleg");
        }

        internal void Run()
        {
            _beleg.Interact(_olaf);
            _priya.Interact(_olaf);
            _olaf.Interact(_priya);
        }
    }
}