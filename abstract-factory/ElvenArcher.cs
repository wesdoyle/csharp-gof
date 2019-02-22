using System;

namespace abstract_factory
{
    public class ElvenArcher : Elf
    {
        public ElvenArcher(string name) : base(name)
        {
        }

        public override void Interact(Elf elf)
        {
            Console.WriteLine("An elf cannot fire another elf!");
        }

        public override void Interact(Human human)
        {
            throw new NotImplementedException();
        }
    }
}