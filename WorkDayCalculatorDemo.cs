/*Приветствую!
В чём заключается суть этого калькулятора.
Мы задаём значения даты начала рабочего периода, количество рабочих дней и выходные дни (в виде массива).
Калькулятор учитывает все выходные и возвращает результат в виде даты окончания рабочего периода.
Запускаем программу и смотрим! :)*/
using System;
using System.IO;

namespace WorkDayCalculator
{
    class WorkDayCalculatorDemo
    {
        static void Main()
        {
            //создаём переменную ссылки типа DateTime для последующей передачи результата выполнения метода Calculate()
            DateTime endDate;
            //создаём переменную ссылки типа WorkDayCalculator и присваиваем ей объект этого класса
            WorkDayCalculator test = new WorkDayCalculator();

            //переходим к параметрам, которые мы будем передавать методу Calculate()
            //для начала параметр даты начала
            DateTime startDate = new DateTime(2021, 12, 28);
            //затем параметр длительности рабочих дней
            int dayCount = 6;
            //затем массив экземпляров класса WeekEnd, один элемент этого массива содержит дату начала и дату конца выходных
            WeekEnd[] weekEnds = new WeekEnd[2] {new WeekEnd(new DateTime(2021, 12, 29), new DateTime(2022, 01, 03)),
                                new WeekEnd(new DateTime(2022, 01, 06), new DateTime(2022, 01, 06))};
            //созданной раннее переменной конечной даты присваиваем значение, получившееся в результате вызова метода Calculate() по ссылке созданного объекта test
            endDate = test.Calculate(startDate, dayCount, weekEnds);
            //после чего выводим результат на экран
            Console.WriteLine("First testing: \n");
            Console.WriteLine("Start date: " + startDate.ToShortDateString() +
                                "\nDuration in days(whole number): " + dayCount +
                                "\nWeekends(array of objects with the fields \"start date\" and \"end date\"): " + weekEnds[0].Show(weekEnds));
            Console.WriteLine("End date: " + endDate.ToShortDateString() + "\n");

            //задаём новые значения параметрам
            startDate = new DateTime(2021, 09, 18);
            dayCount = 8;
            weekEnds = new WeekEnd[] { new WeekEnd(new DateTime(2021, 09, 14), new DateTime(2021, 09, 19)) };
            //вызываем метод Calculate() и записываем его в переменную конечной даты
            endDate = test.Calculate(startDate, dayCount, weekEnds);
            //затем так же выводим результат на экран
            Console.WriteLine("Second testing: \n");
            Console.WriteLine("Start date: " + startDate.ToShortDateString() +
                                "\nDuration in days(whole number): " + dayCount +
                                "\nWeekends(array of objects with the fields \"start date\" and \"end date\"): " + weekEnds[0].Show(weekEnds));
            Console.WriteLine("End date: " + endDate.ToShortDateString() + "\n");

            //здесь можете ввести свои значения и убедиться в правильности работы калькулятора
            Console.WriteLine("\nAnd you can test the Calculator yourself: ");
            start:
            try
            {
                Console.Write("Enter the Start date: ");
                startDate = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter the Duration: ");
                dayCount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the size of the Weekends array: ");
                int size = Convert.ToInt32(Console.ReadLine());
                weekEnds = new WeekEnd[size];
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
                Console.WriteLine("Result: ");
                Console.WriteLine("Start date: " + startDate.ToShortDateString() +
                                    "\nDuration in days(whole number): " + dayCount +
                                    "\nWeekends(array of objects with the fields \"start date\" and \"end date\"): " + weekEnds[0].Show(weekEnds));
                Console.WriteLine("End date: " + endDate.ToShortDateString() + "\n");
            }
            catch(Exception)
            {
                Console.WriteLine("Some wents wrong...");
            }
                Console.WriteLine("Try again? \'y\' - yes");
                if (Console.ReadKey(true).KeyChar == 'y') goto start;
                else return;
        }
    }
}
