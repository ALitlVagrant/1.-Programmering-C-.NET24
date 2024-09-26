namespace InterfaceTryOut;

public abstract class Animal : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("The Animal is eating...");
        
    }

    public string Species;

    public Animal()
    {
        Species = GetType().Name;
    }

    public string GetSpecies()
    {
        Console.WriteLine($"The species is: {Species}");
        return Species;
    }

    public abstract void MakeSound();
}

public class Dog : Animal, IPredator
{
    public void Hunt()
    {
        Console.WriteLine($"The {Species} is hunting...");
    }

    public override void MakeSound()
    {
        Console.WriteLine("The Dog is Barking...");
    }
}

public class Cow : Animal, IPrey
{
    public void Flee()
    {
        Console.WriteLine($"The {Species} is fleeing...");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"The {Species} is Mooing");
    }
}

public class Squid : Animal, IPrey, IPredator
{
    public void Flee()
    {
        Console.WriteLine($"The {Species} is fleeing...");
    }

    public void Hunt()
    {
        Console.WriteLine($"The {Species} is hunting...");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"The {Species} is MRRRLGGGing");
    }
}