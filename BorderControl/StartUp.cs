namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            List<Visitor> visitors = new List<Visitor>();
            int numberOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPeople; i++)
            {
                var tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (!visitors.Any(x=>x.Name == tokens[0]))
                {
                    switch (tokens.Length)
                    {
                        case 4:
                            Citizen citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                            visitors.Add(citizen);
                            break;
                        case 3:
                            Rebel rebel = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
                            visitors.Add(rebel);
                            break;
                    }
                }
            }

            string input;
            while ((input = Console.ReadLine())!="End")
            {
                if (visitors.FirstOrDefault(x=>x.Name == input)!=null)
                {
                    visitors.FirstOrDefault(x => x.Name == input).BuyFood();
                }
            }

            var totalFood = 0;
            foreach (var visitor in visitors)
            {
                totalFood += visitor.Food;
            }
            Console.WriteLine(totalFood);

        }
    }
}
