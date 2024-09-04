namespace Calculator
{
     class Program
    {
        static void Main(string[] args)
        {


            double myNum1 = 0;
            double myNum2 = 0;

            Console.WriteLine("Type a number and press Enter");
            myNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type a number and press Enter");
            myNum2 = Convert.ToDouble(Console.ReadLine());
            DisplayMenu();
            var val = Console.ReadLine();

            if (val.ToUpper() == "a")
            {
                double answerAdd = AddMath(myNum1, myNum2);
                Console.WriteLine($"{myNum1} + {myNum2} = {answerAdd}");
            }
            if (val.ToUpper() == "s")
            {
                double answerSub = SubMath(myNum1, myNum2);
                Console.WriteLine($"{myNum1} - {myNum2} = {answerSub}");
            }
            if (val.ToUpper() == "d")
            {
                double answerMul = MulMath(myNum1, myNum2);
                Console.WriteLine($"{myNum1} * {myNum2} = {answerMul}");
            }

            if (val.ToUpper() == "w")
            {
                while (myNum2 == 0)
                {
                    Console.WriteLine("Please enter a non zero divisor: ");

                    myNum2 = Convert.ToInt32(Console.ReadLine());


                }
                double answerDiv = DivMath(myNum1, myNum2);
                Console.WriteLine($"{myNum1} / {myNum2} = {answerDiv}");

            }
        }
        static void DisplayMenu()
        {
            string[] mainMenu = { "------------------------", "Console Calculator in C#", "Please choose option!:","A - Add","S - Subtract","D - Multiply","W - Divide"};

            foreach(string i in mainMenu)
            {
                Console.WriteLine(i);
            }

        }
        static double AddMath (double addNum1, double addNum2)
        {
            double result = addNum1 + addNum2;
            return result;
        }
        static double SubMath(double subNum1, double subNum2)
        {
            double result = subNum1 - subNum2;
            return result;
        }
        static double MulMath(double mulNum1, double mulNum2)
        {
            double result = mulNum1 * mulNum2;
            return result;
        }
        static double DivMath(double divNum1, double divNum2)
        {
            double result = (divNum1 / divNum2);
            return result;
        }
        
    }
}
