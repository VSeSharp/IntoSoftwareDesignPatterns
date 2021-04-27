using Creational.Factory;
using Creational.Singleton;
using System;
using System.Threading.Tasks;

namespace SoftwareDesignPatternsExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreationalSingleton();
            //CreationalFactory();

            Console.ReadLine();
        }
        public static void CreationalSingleton()
        {
            int number = 10;
            Parallel.For(0, number, count =>
            {
                Singleton current = Singleton.Instance;
            });
        }

        public static void CreationalFactory()
        {
            Card card = CardFactory.GetCard("Platinum");
            if (card != null)
            {
                Console.WriteLine("CreditLimit: " + card.GetCreditLimit());
                Console.WriteLine("AnnualCharge:" + card.GetAnnualCharge());
            }
        }
    }
}
