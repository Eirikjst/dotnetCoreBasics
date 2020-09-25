using System;

namespace ProgrammeringGrunnkurs
{
    /// <summary>
    /// Chapter 2: Variables, types and expressions
    /// </summary>
    class ExerciseOne
    {

        /// <summary>
        /// Converts inch to centimeter.
        /// </summary>
        /// <param name="inch"></param>
        /// <returns></returns>
        private string TaskOne(double inch)
        {
            return $"{inch} inches equals to {inch*2.56} centimeters";
        }

        /// <summary>
        /// Converts hours, minutes and seconds to total seconds.
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        private string TaskTwo(int hours, int minutes, int seconds)
        {
            int totalTime = (hours * 3600) + (minutes * 60) + seconds;
            return $"{hours}h:{minutes}m:{seconds}s equals {totalTime} seconds";
        }

        /// <summary>
        /// Converts seconds into hours, minutes, seconds
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        private string TaskThree(int totalTime)
        {
            int hours = totalTime / 3600;
            int minutes = (totalTime % 3600) / 60;
            int seconds = minutes % 60;

            return $"{totalTime} seconds equals {hours}h:{minutes}m:{seconds}s";
        }

        /// <summary>
        /// Task one: Converts inch to centimeter.
        /// <br></br>
        /// Task two: Converts hours, minutes and seconds to total seconds.
        /// <br></br>
        /// Task three: Converts seconds into hours, minutes, seconds
        /// </summary>
        public void RunTasks()
        {
            Console.WriteLine(
                "Exercise 1, three tasks\n" +
                "Task one: " + TaskOne(5) + "\n" +
                "Task two: " + TaskTwo(0, 5, 3) + "\n" +
                "Task three: " + TaskThree(4000) + "\n"
                );
        }
    }
}