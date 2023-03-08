namespace CSharpAnimal.Models
{
    abstract public class Animal
    {

        public Animal()
        {
            this.name = "Cat";
        }

        public Animal(string name)
        {
            this.name = name;
        }

        public string name { get; set; }

        public virtual void Move()
        {
            Console.WriteLine("Move !");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Sleep !");
        }

    }
}
