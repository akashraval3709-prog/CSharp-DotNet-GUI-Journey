using System;

namespace MethodOverridingDemo
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof Woof!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat says: Meow Meow!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();

            Console.WriteLine("=== Animal Sounds ===\n");

            dog.MakeSound();
            cat.MakeSound();
        }
    }
}
