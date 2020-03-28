namespace BorderControl
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> inhabitant = new List<IIdentifiable>();
            string input;
            while ((input = Console.ReadLine())!= "End")
            {
                var tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (tokens.Length)
                {
                    case 3:
                        Citizen citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
                        inhabitant.Add(citizen);
                        break;
                    case 2:
                        Robot robot = new Robot(tokens[0], tokens[1]);
                        inhabitant.Add(robot);
                        break;
                }
            }
            var fakeIdEndStr = Console.ReadLine();
            foreach (var record in inhabitant)
            {
                if (record.Id.EndsWith(fakeIdEndStr))
                {
                    Console.WriteLine(record.Id);
                }
            }
        }
    }
}
