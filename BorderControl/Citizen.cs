namespace BorderControl
{
    public class Citizen : Visitor, IIdentifiable, IBirthable
    {
        public string Id { get; private set; }
        public int Age { get; private set; }
        public string Birthdate { get; private set; }
        public override int Food { get; protected set; }
        public override string Name { get; protected set; }

        public Citizen(string name,  int age, string id, string birthdate) : base(name)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public override void BuyFood()
        {
            this.Food += 10;
        }
    }
}
