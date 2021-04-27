namespace Creational.AbstractFactory
{
    public class SeaAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string animalType)
        {
            if (animalType.Equals("Octopus"))
            {
                return new Octopus();
            }
            else
                return null;
        }
    }
}
