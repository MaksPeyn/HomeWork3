using System;

namespace Domain
{
    public class Numbertron
    {
        private readonly Random _random = new Random();
        public void Generate()
        {
            int v = _random.Next();
            NewNumber?.Invoke(v);
            Console.WriteLine(v);
        }
        public event Gambler.Number NewNumber;
    }
}
