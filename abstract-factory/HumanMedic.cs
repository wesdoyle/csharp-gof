using System;

namespace abstract_factory
{
    internal class HumanMedic : Human
    {
        public HumanMedic(string name) : base(name)
        {
        }

        public override void Interact(Human human)
        {
            Console.WriteLine($"{this.GetName()} heals {human.GetName()}");
        }

        public override void Interact(Elf elf)
        {
            throw new System.NotImplementedException();
        }
    }
}