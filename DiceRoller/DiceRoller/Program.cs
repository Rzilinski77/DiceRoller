using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task: Create an application that simulates dice rolling.

            //What will the application do? 
            //● The application asks the user to enter the number of sides for a pair of dice.  
            //● The application prompts the user to roll the dice. 
            //● The application “rolls” two n-sided dice, displays the results of each, and then asks the user if he / she wants to roll the dice again.  

            //Build Speciﬁcations 
            //1.Use static methods to implement the method(s) that generate the random numbers.  
            //2.Experiment with diﬀerent Random number generators that you can ﬁnd on the internet.

            //Hints:
            //● Use the Random class to generate a random number.

            //Extended Challenges:  
            //● Use the DiceRollerApp class to display special messages for craps, snake eyes, and box cars

            Console.WriteLine("Welcome to Randy's Dice Rollin' Fun Time Extraviganza!");
            Console.WriteLine("======================================================\n");
            string more = "y";
            do
            {
                Console.WriteLine("How many sides should the dice have?");
                int sides = int.Parse(Console.ReadLine());
                int diceOne = DiceRoll(sides);
                int diceTwo = DiceRoll(sides);
                Console.WriteLine(diceOne);
                Console.WriteLine(diceTwo);
                if (diceOne == 1 && diceTwo == 1)
                {
                    Console.WriteLine("Snake Eyes!");
                }
                else if (diceOne == 6 && diceTwo == 6)
                {
                    Console.WriteLine("Box Cars!");
                }
                Console.WriteLine();
                Console.WriteLine("Do you want to continue? (y/n)");
                more = YesOrNoValidation(Console.ReadLine());


            } while (more == "y");

        }

        static public int DiceRoll(int sides)
        {
            Random rng = new Random();
            int roll = rng.Next(1, (sides + 1));
            return roll;
        }

        static public string YesOrNoValidation(string input)
        {
            input = input.ToLower();
            string go = "y";

            do
            {
                if (input == "y" || input == "n")
                {
                    go = "n";
                }
                else
                {
                    Console.WriteLine("Please enter valid input (y/n)");
                    input = Console.ReadLine();
                }
            } while (go == "y");

            return input;
        }
    }
}
