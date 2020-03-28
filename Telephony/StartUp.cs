namespace Telephony
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            var addresses = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            Smartphone smartphone = new Smartphone();
            foreach (var num in numbers)
            {
                smartphone.Call(num);   
            }
            foreach (var address in addresses)
            {
                smartphone.Browse(address);
            }
        }
    }
}
