using CSharpAnimal.Models;

class Program
{
    static void Main(string[] args)
    {
        Animals myAnimal = new Animals("Fox");

        myAnimal.Sleep();
        myAnimal.Move();
        Console.WriteLine(myAnimal.name);


        Animals myAnimal2 = new Animals();

        myAnimal2.Sleep();
        myAnimal2.Move();
        Console.WriteLine(myAnimal2.name);

    }

}