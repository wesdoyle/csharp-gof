namespace abstract_factory
{
    public abstract class Elf
    {
        private readonly string _name;
        protected Elf(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return this._name;
        }

        public abstract void Interact(Elf elf);
        public abstract void Interact(Human human);
    }
}