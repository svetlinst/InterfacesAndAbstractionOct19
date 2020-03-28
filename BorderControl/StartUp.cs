namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            List<INamable> people = new List<INamable>();
            int numberOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPeople; i++)
            {
                var tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (!people.Any(x=>x.Name == tokens[0]))
                {
                    switch (tokens.Length)
                    {
                        case 4:
                            Citizen citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                            people.Add(citizen);
                            break;
                        case 3:
                            Rebel rebel = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
                            people.Add(rebel);
                            break;
                    }
                }
            }

            string input;
            var totalFood = 0;
            while ((input = Console.ReadLine())!="End")
            {
                if (people.FirstOrDefault(x=>x.Name == input)!=null)
                {
                        
                }
            }
           
        }
    }
}
