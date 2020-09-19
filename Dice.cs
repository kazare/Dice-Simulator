using System;

namespace DiceSimulation
{
    //Class to hold dice caluclation info
    class Dice
    {
        //Initialize variables
        Random random = new Random();
        int dice1;
        int dice2;
        int sum;
        int index;
        int numOfRolls;


        //Create array of all possible sums
        //{sum, frequency}
        int[,] nums = { { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 }, { 10, 0 }, { 11, 0 }, { 12, 0 } };


        //Default number is 72000, user able to override
        public void Rolling(int numOfRolls = 72000)
        {
            this.numOfRolls = numOfRolls;

            for (int i = 0; i < this.numOfRolls; i++)
            {
                //Randomize dice numbers
                //Add the sums together
                dice1 = random.Next(1, 7);
                dice2 = random.Next(1, 7);
                sum = dice1 + dice2;
                index = sum - 2;

                //(sum - 2) corresponds to it's index in the array

                //Increase frquency value by one
                nums[index, 1] += 1;
            }
        }
        //Print out results
        public void Results()
        {
            Console.WriteLine($"\nThe two dice rolled {this.numOfRolls} times \n");

            Console.WriteLine("=====================");
            Console.WriteLine("  Sum  |  Frequency  ");
            Console.WriteLine("=====================");

            //Print out values in array
            for (int item = 0; item < nums.GetLength(0); item++)
            {
                //visual alignment
                if (nums[item, 0] <= 9)
                {
                    Console.WriteLine($"  {nums[item, 0]}    |   {nums[item, 1]}");
                }
                else
                {
                    Console.WriteLine($" {nums[item, 0]}    |   {nums[item, 1]}");
                }
            }
        }
    }
}
