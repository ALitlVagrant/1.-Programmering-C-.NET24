using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract_Classes
{
    public abstract class Animal : IAnimal
    {
        protected string Name;
        protected int Legs;

        public Animal(string name)
        {
            Name = name;
        }
        public abstract void MakeSound();
        public int LegCount()
        {
            Console.WriteLine($"This {GetType().Name} has {Legs} number of legs");
            return Legs;
        }
        public void Eat()
        {
            Console.WriteLine($"The {GetType().Name} is eating...");
        }
        public string GetName()
        {
            Console.WriteLine($"The name of the {GetType().Name} is {Name}");
            return Name;
        }
    }
    public class Dog : Animal
    {
        
        public Dog(string Name) : base(Name) { }

        public override void MakeSound()
        {
            Console.WriteLine("The Dog says: Voff Voff");
        }



    }
    public class Cat : Animal
    {
        
        public Cat(string Name) : base(Name) { }
        public override void MakeSound()
        {
            Console.WriteLine("The Cat says Meow Meow");

        }

    }
    public class Bird : Animal
    {
        public Bird(string Name) : base(Name) { }

        public override void MakeSound()
        {
            Console.WriteLine("The bird says chirp chirp");
        }


    }
}
