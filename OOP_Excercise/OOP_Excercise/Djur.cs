using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //konstruktor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;

        }
        //metod
        public virtual void MakeSound()
        {
            Console.WriteLine("Making Sound...");
        }
    }
    class Dog : Animal
    {
        //public Dog(string name, int age)
        //{
        //    Name = name;
        //    Age = age;
        //}

        public Dog (string name,int age) : base(name,age)
        {
            
        }
        public override void MakeSound()
        {
            Console.WriteLine("VOFF VOFF...");
        }

    }
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name,age)
        {
            
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meow Meow");

        }
    }
}
