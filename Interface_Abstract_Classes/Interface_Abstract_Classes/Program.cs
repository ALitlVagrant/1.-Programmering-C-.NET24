using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Interface_Abstract_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Fido");
            Cat myCat = new Cat("Tjockis");
            Bird myBird = new Bird("Birby");

            

            List<Animal> animals = new List<Animal>
            { myDog, myCat, myBird};

            foreach(var animal in animals)
            {
                animal.GetName();
                animal.Eat();
                animal.MakeSound();
                animal.LegCount();
            }
        }
    }
    interface IAnimal
    {
        string GetName();
        void Eat();
        
    }
}
