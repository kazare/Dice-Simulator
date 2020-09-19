using System;

namespace DiceSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new objects
            Dice dice = new Dice();
            Validation validation = new Validation();

            //Instructions
            Console.WriteLine("You have two six-sided die");
            Console.Write("How many times would you like to roll?  ");
            string input = Console.ReadLine();
            Console.WriteLine(); //Creating line space


            //Validate user input, if false keep asking
            while (!validation.Validate(input))
            {
                input = Console.ReadLine();
            }

            //if input passes validation
            if (validation.Validate(input))
            {
                //convert input to int
                int rolls = Int32.Parse(input);

                //Pass input to method
                dice.Rolling(rolls);
                dice.Results();
            }
        }
    }
}
