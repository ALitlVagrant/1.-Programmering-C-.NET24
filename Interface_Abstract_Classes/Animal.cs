using System;

public abstract class Animal : IAnimal
{
    protected string Name;

    public Animal(string name)
    {
        Name = name;

    }
    public abstract void MakeSound();

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