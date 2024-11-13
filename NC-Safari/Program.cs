using System.Globalization;

namespace NC_Safari
{
    internal class Program
    {
        public static void Main()
        {
            Tiger fluffy = new Tiger(80);
            Penguin penny = new Penguin(20.4f);
            Goose jeff = new Goose(3);
            Bat betty = new Bat(0.7f);

            Sky sky = new Sky();
            sky.AddAnimalInEnvironment(betty);
            sky.AddAnimalInEnvironment(jeff);

            sky.CheckAnimalsInEnvironment();

            Console.WriteLine("-----------------------");

            HuntingGround hunting = new HuntingGround();
            hunting.AddAnimalInEnvironment(betty);
            hunting.AddAnimalInEnvironment(fluffy);
            hunting.AddAnimalInEnvironment(penny);

            hunting.CheckAnimalsInEnvironment();

            Console.WriteLine("-----------------------");

            List<Animal> animalsToSee = new List<Animal>
            {
              new Tiger(70),
              new Goose(5.2f),
              new Bat(0.9f),
              new Goose(4),
              new Tiger(90),
              new Penguin(15.8f)
            };

            animalsToSee.Sort(new CompareWeight(false));

            animalsToSee.ForEach(animal => Console.WriteLine($" {animal.GetType().Name} - {animal.Weight}kg"));

            Tiger pumpkin = new Tiger(100.4);

            pumpkinWeightFormatter = new WeightFormatter(pumpkin, Enums.Culture.DE);
            //consider how you will pass the culture and measurements
        }
    }
}
