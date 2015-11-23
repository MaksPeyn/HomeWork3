using System;

namespace Domain
{
    class Program
    {
        static void Main(){}
    }
    public class Numbertron
    {
        public void Generate()
        {
            var random = new Random();
            NewNumber?.Invoke(random.Next());
        }
        public event Gambler.Number NewNumber;
    }
}
