namespace OOP_Excercise
{
    internal class Program
    {
        //Mål skapa klasser och objekt samt använda egenskaper och metoder!
        static void Main(string[] args)
        {
            TheBloodMeridian bok1 = new TheBloodMeridian();
            bok1.Beskrivning();

            Console.WriteLine();

            //Mål: Förstå hur man använder konstruktorer och implementerar inkapsling.

            //Console.WriteLine("Please submit Name");
            //string nameInput = Console.ReadLine();
            //Console.WriteLine("Please Submit lastname");
            //string lastNameInput = Console.ReadLine();
            //Console.WriteLine("Please submit Age");
            //int inputAge;
            //while (!int.TryParse(Console.ReadLine(), out inputAge) || inputAge < 0)
            //{
            //    Console.WriteLine("Wrong input!");
            //    Console.WriteLine("Please try again!");
            //}
            //Person personInput = new Person(nameInput,lastNameInput,inputAge);
            //personInput.BeskrivningPerson();

            //Inheritance och polymorphism

            


            List<Animal> animals = new List<Animal>
            {
                new Dog("Fido",4),
                new Cat("Tjockis",5)
            };

            foreach(Animal alla in animals)
            {
                Console.WriteLine($"{alla.Name} is making a sound");
                alla.MakeSound();
            }

        }


    }
    

    
}
