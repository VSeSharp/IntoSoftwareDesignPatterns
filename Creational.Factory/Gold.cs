namespace Creational.Factory
{
    class Gold : Card
    {
        public string GetCardType()
        {
            return GetType().Name;
        }
        public int GetCreditLimit()
        {
            return 10000;
        }
        public int GetAnnualCharge()
        {
            return 200;
        }
    }
}
