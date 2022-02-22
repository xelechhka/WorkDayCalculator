using System;

namespace WorkDayCalculator
{
    class WorkDayCalculatorDemo
    {
        static void Main()
        {
            DateTime endDate;
            WorkDayCalculator test = new WorkDayCalculator();
            DateTime startDate = new DateTime(2021, 12, 28);
            int dayCount = 6;
            WeekEnd[] weekEnds = new WeekEnd[2] {new WeekEnd(new DateTime(2021, 12, 29), new DateTime(2022, 01, 03)),
                                new WeekEnd(new DateTime(2022, 01, 06), new DateTime(2022, 01, 06))};
            endDate = test.Calculate(startDate, dayCount, weekEnds);

            Console.WriteLine("First testing: \n");
            Console.WriteLine("Start date: " + startDate.ToShortDateString() +
                                "\nDuration in days(whole number): " + dayCount +
                                "\nWeekends(array of objects with the fields \"start date\" and \"end date\"): " + weekEnds[0].Show(weekEnds));
            Console.WriteLine("End date: " + endDate.ToShortDateString() + "\n");


            startDate = new DateTime(2021, 09, 18);
            dayCount = 8;
            weekEnds = new WeekEnd[] { new WeekEnd(new DateTime(2021, 09, 14), new DateTime(2021, 09, 19)) };
            endDate = test.Calculate(startDate, dayCount, weekEnds);
            Console.WriteLine("Second testing: \n");
            Console.WriteLine("Start date: " + startDate.ToShortDateString() +
                                "\nDuration in days(whole number): " + dayCount +
                                "\nWeekends(array of objects with the fields \"start date\" and \"end date\"): " + weekEnds[0].Show(weekEnds));
            Console.WriteLine("End date: " + endDate.ToShortDateString() + "\n");

            Console.WriteLine("And you can test the Calculator by yourself: ");
            Console.Write("Enter the Start date: ");
            startDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the Duration: ");
            dayCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the size of the Weekends array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            weekEnds = new WeekEnd[size];
            Console.WriteLine();
            Console.WriteLine("Enter dates of weekends: ");
            for (int i = 0; i < size; i++)
            {
                DateTime start = new DateTime();
                DateTime end = new DateTime();
                Console.Write((i + 1) + " start date: ");
                start = Convert.ToDateTime(Console.ReadLine());
                Console.Write((i + 1) + " end date: ");
                end = Convert.ToDateTime(Console.ReadLine());
                weekEnds[i] = new WeekEnd(start, end);
            }
            endDate = test.Calculate(startDate, dayCount, weekEnds);
            Console.WriteLine();
            Console.WriteLine("Result: ");
            Console.WriteLine("Start date: " + startDate.ToShortDateString() +
                                "\nDuration in days(whole number): " + dayCount +
                                "\nWeekends(array of objects with the fields \"start date\" and \"end date\"): " + weekEnds[0].Show(weekEnds));
            Console.WriteLine("End date: " + endDate.ToShortDateString() + "\n");
        }
    }
}
