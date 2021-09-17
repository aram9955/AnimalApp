using System;

namespace AnimalApp
{
    public class Human : Animal
    {
        public void SayHello(string helloObject)
        {
            Console.WriteLine($"{_name} says hello to {helloObject}");
        }

    }
}
