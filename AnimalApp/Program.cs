using System;

namespace AnimalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human._name = "Poghos";
            human.SayHello("Vardan");
            human.Eat("Pig");
            Dog dog = new Dog();
            dog._name = "Jeko";
            dog.Eat("meat");
            dog.Bark("Bad Neigbou");
            Cat cat = new Cat();
            cat._name = "Mourka";
            cat.Eat("Wiskas");
            cat.Meow("no matter");
            Cat ourCat = new Cat();
            ourCat._name = "Gonch";
            ourCat.Eat("Pig");
            ourCat.Meow("never");
            Cow cow = new Cow();
            cow._name = "Tsaghik";
            cow.Eat("grass");
            cow.Mօօ("hungry");

            Console.ReadKey();
        }
    }
}
