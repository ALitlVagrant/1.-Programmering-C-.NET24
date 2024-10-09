namespace InterfaceTryOut;

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        Squid mySquid = new Squid();
        Cow myCow = new Cow();
        Animal myBunny = new Bunny();
        
        myBunny.Eat();
        
        myDog.Eat();
        
        myDog.Hunt();
        
        mySquid.Hunt();
        mySquid.Flee();
        
    }
}


