using CSharpAnimal.Models.Animals;

class Program
{
    static void Main(string[] args)
    {
        Griffin myAnimal = new Griffin();

        myAnimal.Sleep();
        myAnimal.Move();
        Console.WriteLine(myAnimal.griffinName);


        Dragon myAnimal2 = new Dragon();

        myAnimal2.Sleep();
        myAnimal2.Move();
        Console.WriteLine(myAnimal2.dragonName);

    }

}