using System;

namespace ProgrammeringGrunnkurs
{
    /// <summary>
    /// Chapter 4: Loops as controlstructure
    /// </summary>
    class ExerciseThree
    {
        /// <summary>
        /// Print out the multiplication table for numbers within the bounds
        /// </summary>
        /// <param name="lowerBound"></param>
        /// <param name="upperBound"></param>
        public void TaskOne(int lowerBound, int  upperBound)
        {
            for (int i = lowerBound; i <= upperBound; i++)
            {
                Console.WriteLine($"Multiplication table for {i}x10");

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = "+ (i * j));
                    if (j == 10)
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }

        /// <summary>
        /// Prints out the following patterns:
        /// <br>if triangle == false:</br>
        /// <br>*</br>
        /// <br>**<br>
        /// <br>***<br>
        /// <br>...</br>
        /// <br>*************</br>
        /// <br>Decided by user input</br>
        /// <br></br>
        /// <br>if triangle == true:</br>
        /// <br>  *  </br>
        /// <br> *** </br>
        /// <br>*****</br>
        /// <br> ... </br>
        /// </summary>
        /// <param name="numberOfLines"></param>
        /// <param name="triangle"></param>
        public void TaskTwo(int numberOfLines, bool triangle)
        {
            if (!triangle)
            {
                string shape = "*";

                for (int i = 0; i < numberOfLines; i++)
                {
                    Console.WriteLine(shape);
                    if (i < numberOfLines)
                    {
                        shape += "*";
                    }
                }
            } 
            else
            {
                for (int i = 1; i <= numberOfLines; i++)
                {
                    for (int j = numberOfLines; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 0; j < i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
        }

        /// <summary>
        /// Prints out the ASCII value within bounds
        /// </summary>
        public void TaskThree()
        {
            Console.WriteLine("Lower bound: ");
            char lowerBound = char.Parse(Console.ReadLine());
            Console.WriteLine("Upper bound: ");
            char upperBound = char.Parse(Console.ReadLine());

            if (lowerBound > upperBound)
            {
                Console.WriteLine("Lower bound > upper bound, try again");
            } 
            else
            {
                for (char i = lowerBound; i <= upperBound; i++)
                {
                    Console.WriteLine($"{i} has the ASCII value {Convert.ToInt16(i)}");
                }
            }
        }

        public void RunTasks()
        {
            //TaskOne(13, 15);
            //TaskTwo(2, true);
            TaskThree();
        }
    }
}
