namespace BorderControl
{
    public abstract class Visitor : INamable, IBuyer
    {
        public abstract int Food { get; protected set; }

        public abstract string Name { get; protected set; }
        
        public Visitor(string name)
        {
            this.Name = name;
        }

        public abstract void BuyFood();
    }
}
