using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public static class CustomDeconstruct
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("---------- Tuple Custom Deconstruction ----------");

            WithoutTupleDeconstruction();
            WithTupleDeconstruction();

            Console.Write("Press Enter to exit: ");
            Console.ReadLine();
        }

        public static void WithoutTupleDeconstruction()
        {
            var date = DateTime.Today;

            var year = date.Year;
            var month = date.Month;
            var day = date.Day;

            displayInfo(day, month, year, "The old way...");
        }

        public static void WithTupleDeconstruction()
        {
            var (day, month, year) = DateTime.Today;

            displayInfo(day, month, year, "With Deconstruction Extension Method");
        }

        private static void displayInfo(int day, int month, int year, string title)
        {
            Console.WriteLine($"-------- {title} --------");
            Console.WriteLine();
            Console.WriteLine($"Year: {year} Month: {month} Day: {day}");
            Console.WriteLine();
        }
    }

    public static class DateTimeExtensions
    {
        public static void Deconstruct(this DateTime date, out int day, out int month, out int year) =>
            (day, month, year) = (date.Day, date.Month, date.Year);

    }
}
