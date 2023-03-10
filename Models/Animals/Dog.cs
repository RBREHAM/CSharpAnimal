namespace CSharpAnimal.Models.Animals
{
    class Dog : Animal
    {
        public Dog(string name, int age, int id)
        {
            this.Name = name;
            this.Rare = "Common";
            this.Age = age;
            this.Id = id;
        }

    }
}
