using Creational.AbstractFactory;
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
            //CreationalAbstractFactory();

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

        public static void CreationalAbstractFactory()
        {
            Animal animal = null;
            AnimalFactory animalFactory = null;
            animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory Type : " + animalFactory.GetType().Name);
            animal = animalFactory.GetAnimal("Octopus");
            Console.WriteLine(animal.GetType().Name + " saying " + animal.Voice());
            animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory Type : " + animalFactory.GetType().Name);
            animal = animalFactory.GetAnimal("Dog");
            Console.WriteLine(animal.GetType().Name + " saying " + animal.Voice());
        }
    }
}
