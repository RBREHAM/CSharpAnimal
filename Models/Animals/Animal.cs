namespace CSharpAnimal.Models.Animals
{
    abstract public class Animal
    {

        public Animal()
        {
            this.Rare = "Cat";
        }

        public string Name { get; protected set; }
        public string Rare { get; protected set; }
        public int Age { get; protected set; }
        public int Id { get; protected set; }

        public virtual void Move()
        {
            Console.WriteLine("Move !");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Sleep !");
        }

        public virtual void Rarity()
        {
            Console.WriteLine("Sleep !");
        }

    }
}
