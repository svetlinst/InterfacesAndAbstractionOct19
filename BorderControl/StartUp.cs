namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthable> birthables = new List<IBirthable>();
            string input;
            while ((input = Console.ReadLine())!= "End")
            {
                var tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "Citizen":
                        Citizen citizen = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                        birthables.Add(citizen);
                        break;
                    case "Pet":
                        Pet pet = new Pet(tokens[1], tokens[2]);
                        birthables.Add(pet);
                        break;
                }
            }
            var year = int.Parse(Console.ReadLine());
            foreach (var record in birthables)
            {
                if (int.Parse(record.Birthdate.Split('/')[2])==year)
                {
                    Console.WriteLine(record.Birthdate);
                }
            }
        }
    }
}
