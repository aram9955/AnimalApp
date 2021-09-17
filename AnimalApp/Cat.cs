using System;

namespace AnimalApp
{
    public class Cat : Animal
    {
        public void Meow(string meowObject)
        {
            Console.WriteLine($"{_name} meows on {meowObject}");
        }
    }
}
