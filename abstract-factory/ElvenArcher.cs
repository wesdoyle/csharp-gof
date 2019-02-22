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
            Console.WriteLine("An elf cannot attack another elf!");
        }

        public override void Interact(Human human)
        {
            Console.WriteLine($"{this.GetName()} fires an elven arrow at {human.GetName()}");
        }
    }
}