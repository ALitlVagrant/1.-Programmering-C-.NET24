namespace InterfaceTryOut;

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        Squid mySquid = new Squid();
        Cow myCow = new Cow();

        myDog.Hunt();
        mySquid.Hunt();
        mySquid.Flee();
    }
}


