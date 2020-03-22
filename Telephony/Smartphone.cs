namespace Telephony
{
    using System;
    using System.Linq;

    public class Smartphone : ICallable, IBrowsable
    {
        public void Browse(string website)
        {
            if (website.Any(char.IsDigit))
            {
                Console.WriteLine($"Invalid URL!");
                return;
            }            
            Console.WriteLine($"Browsing: {website}");
        }

        public void Call(string phoneNumber)
        {
            if (phoneNumber.Any(char.IsLetter))
            {
                Console.WriteLine($"Invalid number!");
                return;
            }
            Console.WriteLine($"Calling... {phoneNumber}");
        }
    }
}
