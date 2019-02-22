namespace abstract_factory.Archers
{
    internal class ArcherFactory : PlayerFactory
    {
        public ArcherFactory()
        {
        }

        public override Human CreateHuman(string name)
        {
            return new HumanArcher(name);
        }

        public override Elf CreateElf(string name)
        {
            return new ElvenArcher(name);
        }
    }
}
