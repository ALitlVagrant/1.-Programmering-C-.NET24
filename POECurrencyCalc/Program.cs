namespace POECurrencyCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input current Divine price in Chaos orb!");
            double priceCheckDiv = double.Parse(Console.ReadLine());
            Currency currency = new Currency(priceCheckDiv);

            bool myBool = true;

            while (myBool)
            {
                MenuOptions();
                string currencyChoice = Console.ReadLine();
                if (currencyChoice == "DC")
                {
                    Console.WriteLine("Please enter how many Divines you have!");
                    double numberOfDivines;
                    while(!double.TryParse(Console.ReadLine(), out numberOfDivines) || numberOfDivines < 0)
                    {
                        Console.WriteLine("Wrong input!");
                    }
                    double answerDivineInfo = currency.DivineToChaosConvert(numberOfDivines);
                    Console.WriteLine($"Your {numberOfDivines} are worth {answerDivineInfo} worth of Chaos!");

                }
                else if (currencyChoice == "CD")
                {
                    Console.WriteLine("Please enter how many Chaos you have!");
                    double numberOfChaos;
                    while (!double.TryParse(Console.ReadLine(), out numberOfChaos) || numberOfChaos < 0)
                    {
                        Console.WriteLine("Wrong input!");
                    }
                    double answerChaosInfo = currency.ChaosToDivineConvert(numberOfChaos);
                    Console.WriteLine($"Your {numberOfChaos} Chaos are worth {answerChaosInfo} worth of Divines");
                }
                else if (currencyChoice == "Q")
                {
                    Console.WriteLine("Exiting...");
                    myBool = false;
                }
                

            }

        }
        public static void MenuOptions()
        {
            string[] menuOptions = { "What do you want to do?", "Convert Divine to Chaos(DC)", "Convert Chaos to Divine (CD)","To Quit Press (Q)"};
            foreach (string option in menuOptions)
            {
                Console.WriteLine(option);
            }    
        }
    }
}
