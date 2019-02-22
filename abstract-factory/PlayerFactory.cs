namespace abstract_factory
{
    /// <summary>
    /// 'AbstractFactory' class for a Player
    /// </summary>
    internal abstract class PlayerFactory
    {
        public abstract Human CreateHuman(string name);
        public abstract Elf CreateElf(string name);
    }
}