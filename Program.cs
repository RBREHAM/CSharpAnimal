using CSharpAnimal.Models.Animals;

class Program
{
    static void Main(string[] args)
    {
        Griffin griffin1 = new Griffin("Peter", 500, 1);

        Console.WriteLine("Griffin class call :");
        griffin1.Sleep();
        griffin1.Move();
        griffin1.Fly();
        Console.WriteLine(griffin1.Name);

        Console.WriteLine("");








        Dragon dragon1 = new Dragon("Dragy", 30000, 2);

        Console.WriteLine("Dragon class call :");
        dragon1.Sleep();
        dragon1.Move();
        dragon1.Moove();
        dragon1.Fly();
        Console.WriteLine(dragon1.Name);

        Console.WriteLine("");









        Dog dog1 = new Dog("Odin", 4, 3);
        Dog dog2 = new Dog("TomTom", 12, 4);
        Dog dog3 = new Dog("Eliot", 14, 5);
        Dog dog4 = new Dog("Snow", 2, 6);
        Dog dog5 = new Dog("Fraya", 7, 7);

        Dog[] dogs = { dog1, dog2, dog3, dog4, dog5 };

        IEnumerable<Dog> showable =
            from dog in dogs
            where dog.Name != "Snow"
            select dog;

        Console.WriteLine("All dog names except Snow :");
        foreach (Dog dog in showable)
        {
            Console.WriteLine(dog.Name);
        }


        Console.WriteLine("");








        Animal[] animals = { griffin1, dragon1, dog1, dog2, dog3, dog4, dog5 };
        IEnumerable<Animal> showable2 = animals.Where(animal => animal.Rare == "Rare");

        Console.WriteLine("Rare animal(s) name and ID :");
        foreach (Animal animal in showable2)
        {
            Console.WriteLine(animal.Name);
            Console.WriteLine(animal.Id);
        }


        Console.WriteLine("");

        var sortedliste = from animal in animals.OrderByDescending(c => c.Age).ToList()
                          where animal.Rare == "Common"
                          select animal;

        Console.WriteLine("Common animal(s) name :");
        foreach (Animal animal in sortedliste)
        {
            Console.WriteLine(animal.Name);
        }







        Console.WriteLine("");

        Bird bird1 = new Bird("Pioupiou", 1, 8);

        bird1.Sleep();
        bird1.Move();
        bird1.Fly();
        Console.WriteLine(bird1.Name);

        Console.WriteLine("");

        Eagle eagle1 = new Eagle("Desert", 10, 9);

        eagle1.Sleep();
        eagle1.Move();
        eagle1.Fly();
        Console.WriteLine(eagle1.Name);

        Console.WriteLine("");

    }

}