namespace CSharpAnimal.Models.Animals
{
    abstract public class Animal
    {

        public Animal()
        {
            name = "Cat";
        }

        public Animal(string name, string rarity)
        {
            this.name = name;
        }

        public string name { get; set; }
        public string rarity { get; set; }

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
