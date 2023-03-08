namespace CSharpAnimal.Models.Animals
{
    class Griffin : Animal
    {
        public Griffin(string rarity)
        {
            griffinName = "Griffin";
            this.rarity = rarity;
        }


        public string griffinName { get; private set; }

        public override void Move()
        {
            Console.WriteLine($"{griffinName} move");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{griffinName} sleep");
        }
    }
}
