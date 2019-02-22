using System;

namespace abstract_factory.Healers
{
    internal class HumanMedic : Human
    {
        public HumanMedic(string name) : base(name)
        {
        }

        public override void Interact(Human human)
        {
            Console.WriteLine($"{this.GetName()} bandages {human.GetName()}");
        }

        public override void Interact(Elf elf)
        {
            Console.WriteLine($"{this.GetName()} gives potion to {elf.GetName()}");
        }
    }
}