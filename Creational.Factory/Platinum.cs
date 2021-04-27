namespace Creational.Factory
{
    class Platinum : Card
    {
        public string GetCardType()
        {
            return GetType().Name;
        }
        public int GetCreditLimit()
        {
            return 100000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
