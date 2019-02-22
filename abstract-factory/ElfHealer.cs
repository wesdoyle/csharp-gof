using System;

namespace abstract_factory
{
    internal class ElfHealer : Elf
    {
        public ElfHealer(string name) : base(name)
        {
        }

        public override void Interact(Elf elf)
        {
            Console.WriteLine($"{this.GetName()} gives bread to {elf.GetName()}");
        }

        public override void Interact(Human human)
        {
            throw new NotImplementedException();
        }
    }
}