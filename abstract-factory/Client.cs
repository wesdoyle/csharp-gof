using System;

namespace abstract_factory
{
    /// <summary>
    /// The Client. Here, our objects are created and put to use
    /// </summary>
    internal class Client
    {
        private readonly Human _human; 
        private readonly Elf _elf;

        public Client(PlayerFactory playerFactory)
        {
            _human = playerFactory.CreateHuman("Priya");
            _elf = playerFactory.CreateElf("Beleg");
        }

        internal void Run()
        {
            _elf.Interact(_elf);
            _human.Interact(_elf);
            _human.Interact(_human);
        }
    }
}