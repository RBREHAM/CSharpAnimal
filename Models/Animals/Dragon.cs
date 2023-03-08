using CSharpAnimal.Models.Vehicules;

namespace CSharpAnimal.Models.Animals
{
    class Dragon : Animal, IPilotage
    {
        public Dragon()
        {
            dragonName = "Dragon";
        }
        public string dragonName { get; private set; }

        public void Moove()
        {
            Console.WriteLine("allons y lessgooo");
        }

        public override void Move()
        {
            Console.WriteLine($"{dragonName} move");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{dragonName} sleep");
        }
    }
}
