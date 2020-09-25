using System;

namespace ProgrammeringGrunnkurs
{
    class Exams
    {
        public Exams(string type, int numberOfExams, double examLength)
        {
            Type = type;
            NumberOfExams = numberOfExams;
            ExamLength = examLength;
        }

        private string Type { get; }

        private int NumberOfExams { get; }

        private double ExamLength { get; }

        public double HoursOfWork()
        {
            double hoursPaidWork;

            switch (Type)
            {
                case "oral":
                    hoursPaidWork = (3 + ExamLength);
                    break;

                case "project":
                    hoursPaidWork = (NumberOfExams * 8);
                    break;

                case "written":
                    if (NumberOfExams <= 10)
                    {
                        hoursPaidWork = 3 + (0.15 * NumberOfExams * ExamLength);
                    }
                    else
                    {
                        hoursPaidWork = 3 + ((0.15 * 10 * ExamLength) + (0.1 * (NumberOfExams - 10) * ExamLength));
                    }
                    break;

                default:
                    hoursPaidWork = 0;
                    break;
            }
            return hoursPaidWork;
        }

    }

    /// <summary>
    /// Classes as 
    /// </summary>
    class ExerciseFive
    {
        public void RunTasks()
        {
            Exams first = new Exams("oral", 0, 15.5);
            Exams second = new Exams("written", 50, 4);
            Exams third = new Exams("written", 10, 5);
            Exams fourth = new Exams("written", 5, 3);
            Exams fifth = new Exams("project", 5, 0);

            Console.WriteLine(
                "Task one:\n" +
                "First exam number of hours: " + first.HoursOfWork() + "\n" +
                "Second exam number of hours: " + second.HoursOfWork() + "\n" +
                "Third exam number of hours: " + third.HoursOfWork() + "\n" +
                "Fourth exam number of hours: " + fourth.HoursOfWork() + "\n" +
                "Fifth exam number of hours: " + fifth.HoursOfWork()
                );

        }
    }
}