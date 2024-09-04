namespace Calculator
{
     class Program
    {
        static void Main(string[] args)
        {

            double myNum1 = 0;
            double myNum2 = 0;

            Console.WriteLine("Console Calculator in C#");
            Console.WriteLine("------------------------");


            Console.WriteLine("Type a number and press Enter");
            myNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type a number and press Enter");
            myNum2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please choose option");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\td - Multiply");
            Console.WriteLine("\tw - Divide");

            Console.Write("Your Option?");

            var val = Console.ReadLine();

            if (val == "a")
            {
                Console.WriteLine($"Your result: {myNum1} + {myNum2} = " + (myNum1 + myNum2));
            }
            if (val == "s")
            {
                Console.WriteLine($"Your result: {myNum1} - {myNum2} = " + (myNum1 - myNum2));
            }
            if (val == "d")
            {
                Console.WriteLine($"Your result: {myNum1} * {myNum2} = " + (myNum1 * myNum2));
            }
            if(val == "w")
            {
                while (myNum2 == 0)
                {
                    Console.WriteLine("Please enter a non zero divisor: ");

                    myNum2 = Convert.ToInt32(Console.ReadLine());


                }
                Console.WriteLine($"Your result: {myNum1} / {myNum2} = " + (myNum1 / myNum2));


            }
            

           


        }
    }
}
