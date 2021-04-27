namespace Creational.Factory
{
    class Red : Card
    {
        public string GetCardType()
        {
            return GetType().Name;
        }
        public int GetCreditLimit()
        {
            return 1000;
        }
        public int GetAnnualCharge()
        {
            return 100;
        }
    }
}
