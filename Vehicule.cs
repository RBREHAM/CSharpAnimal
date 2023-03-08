namespace CSharpAnimal
{
    class Vehicule
    {
        public Vehicule(string name)
        {
            this.name = name;
        }

        public string name { get; set; }

        public virtual void embarquer()
        {
            Console.WriteLine("On embarque !");
        }
        public virtual void avancer()
        {
            Console.WriteLine("On avance !");
        }
        public virtual void reculer()
        {
            Console.WriteLine("On recule !");
        }
    }
}
