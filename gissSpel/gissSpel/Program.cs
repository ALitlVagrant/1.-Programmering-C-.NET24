using System.ComponentModel.Design;

namespace gissSpel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            while (true) 
            {
                int randomNumber = rnd.Next(1,101);

                try
                {

                    Console.WriteLine("Do you wanna play a Game? Y/N ");
                    string val = Console.ReadLine();
                    int k = 5;
                    
                
                    if (val == "Y")
                    {
                        Console.WriteLine();
                        Console.WriteLine("We shall play the guessing game\n I will choose a number between 1 - 100 \n Lets see how many guesses it takes you to get it right!");
                        Console.WriteLine("Press Q to quit playing");
                        Console.WriteLine();
                        int guessCount = 0;
                        while (k>0)
                        {
                            Console.WriteLine($"K = {k} ");
                            Console.WriteLine($"Guess a number \n You have: {k} guesses left");
                            guessCount++;
                            int val1 = Convert.ToInt32(Console.ReadLine());
                            k--;
                            if (val1 == randomNumber)
                            {
                                Console.WriteLine($"Congratz You guessed the right number {randomNumber} !!!");
                                Console.WriteLine($"It took you {guessCount} guesses!");
                                Console.WriteLine();
                                break;
                                //Console.WriteLine("Wanna play again?\n Y/N? ");

                                ////string igen = Console.ReadLine();
                                ////if (igen == "Y")
                                ////{
                                ////    continue;
                                ////}
                                ////else if (igen == "N") ;
                                ////{
                                ////    break;
                                ////}
                            }
                            if (k==0)
                            {
                                Console.WriteLine("You are out of guesses!");
                                break;
                            }
                            if (val1 > randomNumber)
                            {
                                Console.WriteLine("Too High!");

                            }
                            if (val1 < randomNumber)
                            {
                                Console.WriteLine("Too Low");
                            }
                        }
                    }
                    else if (val == "N")
                    {
                        Console.WriteLine("Bye bye");
                        break;
                    }
                    else 
                    {
                            Console.WriteLine("Invalid Input. Please Try again");
                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong");
                }
            }
        }
    }
}
