using System;
using System.Collections.Generic;
using System.Globalization;

namespace DEC_CourseAssignments
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter The First Activity Start Date in dd/mm/yyyy format, e.g. 19/06/2020");
            var provider = CultureInfo.InvariantCulture;
            var userInput = Console.ReadLine();
            var validInput = DateTime.TryParseExact(userInput, "dd/MM/yyyy", provider, DateTimeStyles.None,
                out var activity1Start);
            if (!validInput)
            {
                Console.WriteLine("Wrong date format!");
            }
            else
            {
                var activity1Duration = 15;
                var activity1Finish = activity1Start.AddDays(activity1Duration);
                //————————————————————————————————————————————//
                var activity2Start = activity1Start;
                var activity2Lead = 10;
                var activity2Duration = activity1Duration + activity2Lead;
                var activity2Finish = activity1Start.AddDays(activity2Duration);
                //————————————————————————————————————————————//
                var activity3Duration = 45;
                var activity3Start = activity1Finish;
                var activity3Finish = activity3Start.AddDays(activity3Duration);
                //————————————————————————————————————————————//
                var activity4Duration = 20;
                var activity4Start = activity2Finish;
                var activity4Finish = activity4Start.AddDays(activity4Duration);
                //————————————————————————————————————————————//
                var activity5Duration = 4;
                var activity5Start = activity2Finish;
                var activity5Finish = activity5Start.AddDays(activity5Duration);
                //————————————————————————————————————————————//
                var activity6Duration = 30;
                var dates = new List<DateTime> { activity3Finish, activity4Finish, activity5Finish };
                var latestDate = DateTime.MinValue;
                foreach (var date in dates)
                {
                    if (DateTime.Compare(date, latestDate) == 1)
                        latestDate = date;
                }
                var activity6Start = latestDate;
                var activity6Finish = activity6Start.AddDays(activity6Duration);
                //————————————————————————————————————————————//
                var projectDuration = activity6Finish - activity1Start;

                Console.WriteLine($"•1: Activity 1 Finish date {activity1Finish.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"•2: Activity 2 Finish date {activity2Finish.ToString("dd/MM/yyyy")} —  Duration is {activity2Duration.ToString("d")}");
                Console.WriteLine($"•3: Activity 3 Finish date {activity3Finish.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"•4: Activity 4 Finish date {activity4Finish.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"•5: Activity 5 Finish date {activity5Finish.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"•6: Activity 6 Finish date {activity6Finish.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"————————————————————————————————————");
                Console.WriteLine($"•*: Total Project Duration {projectDuration.Days} day");
            }
            Console.ReadKey();
        }
    }
}