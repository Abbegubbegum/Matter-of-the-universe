using System;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            int intAns = 0;
            string stringAns = "";
            int points = 0;

            //Asks the question and receives input
            Console.WriteLine("x * 6 = 42");
            Console.WriteLine("What is x?");
            stringAns = Console.ReadLine();

            //Check that the input is in correct form and keeps the user there until
            while (int.TryParse(stringAns, out intAns) == false)
            {
                System.Console.WriteLine("That's not an integer! Try again!");
                stringAns = Console.ReadLine();
            }

            //Checks if they answered correct
            if (intAns * 6 == 42)
            {
                System.Console.WriteLine("Correct!");
                points++;
            }
            else
            {
                System.Console.WriteLine("Nope, " + intAns + " * 6 = " + (intAns * 6));
            }

            //Output
            System.Console.WriteLine("Points: " + points);
            Console.ReadLine();
        }
    }
}
