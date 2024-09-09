using System.Xml;

namespace method_Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //invokar metoden 'Sum' med värdena 10,15
            int res = Sum(10,15);
            //skriver ut resultatet till konsol
            Console.WriteLine($"Resultat = {res}");

            //Invokar metoden 'Greet' med stringen Jacob
            Greet("Jacob");
            Greet("Sangeetha");
            
            
            IsEven(10);
            IsEven(3);


            ReverseStrings("HEJSAN");


        }

        static string ReverseStrings(string sentence)
        {
            char[] myArray = sentence.ToCharArray();
            Array.Reverse(myArray);

            string reversedSentence = new string (myArray);
            Console.WriteLine(reversedSentence);
            return reversedSentence;
        }

        static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number");
                return true;
            }
            else
            {
                Console.WriteLine($"{num} is an odd number");
                return false;
            }
        }

        //skapar 'Greet' metoden med en string parameter
        static void Greet(string name)
        {
            //Skriver ut till konsolen
            Console.WriteLine($"Hej {name}");
        }

        //Skapar 'Sum' metod med parametrarna int num1 och int num2
        static int Sum(int num1, int num2)
        {
            //skapar värdet resultat som tilldelas värdet num1 + num2 
            int result = num1 + num2;
            return result;//returnerar värdet i result variabel
        }


    }
}
