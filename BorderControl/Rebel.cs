namespace BorderControl
{
    public class Rebel : Visitor
    {
        public int Age { get; private set; }
        public string Group { get; private set; }
        public override int Food { get; protected set; }
        public override string Name { get; protected set; }

        public Rebel(string name,  int age, string group) : base(name)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public override void BuyFood()
        {
            this.Food += 5;
        }
    }
}
