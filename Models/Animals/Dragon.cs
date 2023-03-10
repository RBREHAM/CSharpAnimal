using CSharpAnimal.Models.Vehicules;

namespace CSharpAnimal.Models.Animals
{
    class Dragon : Animal, IPilotage
    {
        public Dragon(string name, int age, int id)
        {
            this.Name = name;
            this.Rare = "Rare";
            this.Age = age;
            this.Id = id;
        }

        public void Moove()
        {
            Console.WriteLine("allons y lessgooo");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} move");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{Name} sleep");
        }
    }
}
