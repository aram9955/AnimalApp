using System;

namespace AnimalApp
{
    public class Animal
    {
        public Animal()
        {

        }
        public string _name;
        public void Eat(string eatObject)
        {
            Console.WriteLine($"{_name} eats {eatObject}");
        }
    }
}
