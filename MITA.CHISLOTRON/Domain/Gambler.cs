namespace Domain
{
    public abstract class Gambler
    {
        protected Gambler(string name)
        {
            Name = name;
        }
        public int Score { get; protected set; }
        public delegate void Number (int number);
        public string Name { get; }
        public abstract void FetchNewNumber(int number);
    }
}