using System;

namespace ProgrammeringGrunnkurs
{
    /// <summary>
    /// Chapter 3: If/else as controlstructure
    /// </summary>
    class ExerciseTwo
    {
        /// <summary>
        /// Returns office number given a specific birthdate. 
        /// <br></br>Valid input is 1-31, anything outside bounds returns 0
        /// </summary>
        /// <param name="birthday"></param>
        /// <returns></returns>
        private int TaskOne(int birthday)
        {
            if (birthday >= 1 && birthday < 9) {
                return 113;
            } else if (birthday > 8 && birthday < 15) {
                return 120;
            } else if (birthday > 14 && birthday < 26) {
                return 125;
            } else if (birthday < 25 && birthday < 32) {
                return 134;
            } else {
                return 0;
            }
        }

        /// <summary>
        /// Make a Programet that takes a number(integer) and checks if it:
        /// <br>- is the number positiv or negative</br>
        /// <br>- is the number dividable by a given number </br>
        /// <br>- is the number within a given bound</br>
        /// </summary>
        /// <param name="number"></param>
        /// <param name="divide"></param>
        /// <param name="lowerBound"></param>
        /// <param name="upperBound"></param>
        /// <returns></returns>
        public string TaskTwo(int number, int divide, int lowerBound, int upperBound)
        {
            string res = "\n";

            if (lowerBound > upperBound) 
            {
                return "Lower bound is bigger than upper bound, try again.";
            }

            if (number >= 0) 
            {
                res += $"{number} is positive\n";
            } 
            else 
            {
                res += $"{number} is negative\n";
            }

            if (number % divide == 0) 
            {
                res += $"{number} is dividable by {divide}\n";
            } 
            else 
            {
                res += $"{number} is not dividable by {divide}\n";
            }

            if (number >= lowerBound && number <= upperBound) 
            {
                res += $"{number} is within the bound {lowerBound}-{upperBound}";
            } 
            else 
            {
                res += $"{number} is not within the bound {lowerBound}-{upperBound}";
            }

            return res;
        }

        private void TaskThree()
        {
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            } 
        }

        private void TaskFour()
        {
            double productAWeigth = 450;
            double productAPrice = 35.9;
            double productBWeight = 500;
            double productBPrice = 39.5;

            if ((productAWeigth / productAPrice) > (productBWeight / productBPrice))
            {
                Console.WriteLine("Product B is cheapest");
            } 
            else
            {
                Console.WriteLine("Product A is cheapest");
            }
        }

        public void RunTasks()
        {
            Console.WriteLine(
                "Exercise 2, four tasks\n" + 
                "Task One: " + TaskOne(5) + "\n" +
                "Task Two: " + TaskTwo(10, 4, 11, 15) + "\n"
                );
            TaskThree();
            TaskFour();
        }
    }
}
