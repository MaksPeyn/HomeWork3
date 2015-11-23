using Domain.Extensions;

namespace Domain
{
    public class Jay: Gambler
    {
        public Jay(): base("Jay") {}
        public override void FetchNewNumber(int number)
        {
            if (number.IsEven()) Score++;
        }
    }
}