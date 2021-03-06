using System;

namespace abstract_factory.Archers
{
    internal class HumanArcher : Human
    {
        public HumanArcher(string name) : base(name)
        {
        }

        public override void Interact(Human human)
        {
            Console.WriteLine($"{this.GetName()} fires an arrow at {human.GetName()}!");
        }

        public override void Interact(Elf elf)
        {
            Console.WriteLine($"{this.GetName()} fires a silver arrow at {elf.GetName()}!");
        }
    }
}