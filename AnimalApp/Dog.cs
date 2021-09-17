using System;

namespace AnimalApp
{
    public class Dog : Animal
    {
        public void Bark(string barkObject)
        {
            Console.WriteLine($"{_name} Barks on {barkObject} ");
        }
    }
}
