namespace abstract_factory
{
    internal class HealerFactory : PlayerFactory
    {
        public HealerFactory()
        {
        }

        public override Human CreateHuman(string name)
        {
            return new HumanMedic(name);
        }

        public override Elf CreateElf(string name)
        {
            return new ElfHealer(name);
        }
    }
}