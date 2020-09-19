using System;

namespace DiceSimulation
{
    //Handle validation
    class Validation
    {

        public bool Validate(string input)
        {
            //Try to convert string to int
            if (Int32.TryParse(input, out int number))
            {
                //Prevent user from enterting 0 rolls
                if (Int32.Parse(input) <= 0)
                {
                    Console.Write("Please type a number greater than 0: ");
                    return false;
                }
                else
                {
                    //If number return true
                    return true;
                }
            }
            //If input is not a number
            else
            {
                Console.Write("Please type a number: ");
                return false;
            }
        }
    }
}
