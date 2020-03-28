namespace BorderControl
{
    public abstract class Visitor : INamable, IBuyer
    {
        public virtual int Food { get; private set; }

        public virtual string Name { get; private set; }

        public virtual void BuyFood()
        {
            
        }

        public Visitor(string name)
        {
            this.Name = name;
        }
    }
}
