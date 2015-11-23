using Domain.Extensions;

namespace Domain
{
    public class SilentBob: Gambler
    {
        public SilentBob(): base("SilentBob"){}
        public override void FetchNewNumber(int number)
        {
            if (!number.IsEven()) Score++;
        }
    }
}