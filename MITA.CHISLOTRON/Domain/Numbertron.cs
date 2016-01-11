using System;

namespace Domain
{
    public class Numbertron
    {
        private readonly Random _random = new Random();
        public void Generate()
        {
            NewNumber?.Invoke(_random.Next());
        }
        public event Gambler.Number NewNumber;
    }
}
