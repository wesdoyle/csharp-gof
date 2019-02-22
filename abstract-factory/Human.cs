namespace abstract_factory
{
    public abstract class Human
    {
        private readonly string _name;
        protected Human(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return this._name;
        }
        
        public abstract void Interact(Human human);
        public abstract void Interact(Elf elf);
    }
}