namespace CSharpAnimal.Models
{
    public class Animals
    {

        public Animals()
        {
            this.name = "Cat";
        }

        public Animals(string name)
        {
            this.name = name;
        }

        public string name { get; set; }

        public void Move()
        {
            Console.WriteLine("Move !");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep !");
        }

    }
}
