namespace CSharpAnimal.Models.Animals
{
    class Dragon : Animal
    {
        public Dragon()
        {
            dragonName = "Dragon";
        }
        public string dragonName { get; private set; }

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
