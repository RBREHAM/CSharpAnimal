namespace CSharpAnimal.Models.Vehicules
{
    class Vehicule : IPilotage, IFly
    {
        public void Fly()
        {
            Console.WriteLine("On décole !");
        }

        public void Moove()
        {
            Console.WriteLine("On bouge ! !");
        }
    }
}
