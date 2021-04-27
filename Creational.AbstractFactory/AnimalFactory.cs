namespace Creational.AbstractFactory
{
    public abstract class AnimalFactory
    {
        public abstract Animal GetAnimal(string animaltype);
        public static AnimalFactory CreateAnimalFactory(string factoryType)
        {
            if (factoryType.Equals("Sea"))
            {
                return new SeaAnimalFactory();
            }
            
            return new LandAnimalFactory();
        }
    }
}
