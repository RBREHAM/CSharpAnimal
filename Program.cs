using CSharpAnimal.Models.Animals;
using CSharpAnimal;

class Program
{
    static void Main(string[] args)
    {
        Griffin griffin1 = new Griffin("legendary");

        griffin1.Sleep();
        griffin1.Move();
        Console.WriteLine(griffin1.griffinName);


        Dragon dragon1 = new Dragon("rare");

        dragon1.Sleep();
        dragon1.Move();
        dragon1.Moove();
        Console.WriteLine(dragon1.dragonName);

        Console.WriteLine("");


        Dog dog1 = new Dog("Odin", "common");
        Dog dog2 = new Dog("TomTom", "common");
        Dog dog3 = new Dog("Eliot", "common");
        Dog dog4 = new Dog("Snow", "common");
        Dog dog5 = new Dog("Fraya", "common");

        Dog[] dogs = { dog1, dog2, dog3, dog4, dog5 };

        IEnumerable<Dog> showable =
            from dog in dogs
            where dog.name != "Snow"
            select dog;

        foreach(Dog dog in showable)
        {
            Console.WriteLine(dog.name);
        }


        Console.WriteLine("");


        Animal[] animals = { griffin1, dragon1, dog1, dog2, dog3, dog4, dog5 };
        IEnumerable<Animal> showable2 =
            from animal in animals
            where animal.rarity == "rare"
            select animal;

        foreach (Animal animal in showable2)
        {
            Console.WriteLine(animal.name);
        }


    }

}