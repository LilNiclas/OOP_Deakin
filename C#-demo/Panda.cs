using System.Reflection.Metadata.Ecma335;

namespace Zoo
{
    public class Panda
    {
        public string name;
        public int age;
        public double weight;

        public Panda(string _name, int _age, double _weight)
        {
            name = _name;
            age = _age;
            weight = _weight;
        }

        public void TellAbout()
        {
            Console.WriteLine("Yo I'm " + name + " . I'm " + age + " years old");
        }

        public void Eat()
        {
            Console.WriteLine("Mums!");
        }
    }
}