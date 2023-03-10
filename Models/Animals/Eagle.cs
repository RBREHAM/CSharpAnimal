using CSharpAnimal.Models.Vehicules;

namespace CSharpAnimal.Models.Animals
{
    class Eagle : Animal, IFly
    {
        public Eagle(string name, int age, int id)
        {
            this.Name = name;
            this.Rare = "rare";
            this.Age = age;
            this.Id = id;
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} move");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{Name} sleep");
        }

        public void Fly()
        {
            Console.WriteLine("On décole !");
        }
    }
}