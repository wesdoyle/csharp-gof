using System;

namespace abstract_factory.Healers
{
    internal class ElfHealer : Elf
    {
        public ElfHealer(string name) : base(name)
        {
        }

        public override void Interact(Elf elf)
        {
            Console.WriteLine($"{this.GetName()} magically heals {elf.GetName()}");
        }

        public override void Interact(Human human)
        {
            Console.WriteLine($"{this.GetName()} gives elven bread to {human.GetName()}");
        }
    }
}