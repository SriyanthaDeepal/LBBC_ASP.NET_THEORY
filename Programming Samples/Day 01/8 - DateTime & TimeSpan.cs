using System;

class Program
{
    static void Main()
    {

        // ------------------------------------------------------------------ DateTime in C# -------------------------------------------------------------------- //

        // Get current local DateTime
        DateTime now = DateTime.Now;
        Console.WriteLine("Current DateTime: " + now); // Example: 7/28/2025 5:45:32 PM

        // Get UTC DateTime
        DateTime utcNow = DateTime.UtcNow;
        Console.WriteLine("Current UTC Time: " + utcNow); // Example: 7/28/2025 12:15:32 PM

        // Get only today's date (time set to 00:00:00)
        DateTime today = DateTime.Today;
        Console.WriteLine("Today's Date: " + today.ToString("d")); // Example: 7/28/2025

        // Extract components
        Console.WriteLine("Year: " + now.Year); // Example: 2025
        Console.WriteLine("Month: " + now.Month); // Example: 7
        Console.WriteLine("Day: " + now.Day); // Example: 28
        Console.WriteLine("Hour: " + now.Hour); // Example: 17 (5 PM)
        Console.WriteLine("Minute: " + now.Minute); // Example: 45
        Console.WriteLine("Second: " + now.Second); // Example: 32
        Console.WriteLine("Millisecond: " + now.Millisecond); // Example: 123

        // Get the day of the week
        Console.WriteLine("Day of Week: " + now.DayOfWeek); // Example: Monday

        // Get the number of days in a specific month
        Console.WriteLine("Days in February 2024: " + DateTime.DaysInMonth(2024, 2)); // 29
        Console.WriteLine("Days in February 2025: " + DateTime.DaysInMonth(2025, 2)); // 28

        // Check if a year is a leap year
        Console.WriteLine("Is 2024 a leap year? " + DateTime.IsLeapYear(2024)); // True
        Console.WriteLine("Is 2025 a leap year? " + DateTime.IsLeapYear(2025)); // False



        // DateTime Formatting

        Console.WriteLine("Short Date: " + now.ToString("d")); // Example: 7/28/2025
        Console.WriteLine("Long Date: " + now.ToString("D")); // Example: Monday, July 28, 2025
        Console.WriteLine("Short Time: " + now.ToString("t")); // Example: 5:45 PM
        Console.WriteLine("Long Time: " + now.ToString("T")); // Example: 5:45:32 PM
        Console.WriteLine("Full Date/Time: " + now.ToString("F")); // Example: Monday, July 28, 2025 5:45:32 PM
        Console.WriteLine("Custom Format: " + now.ToString("yyyy-MM-dd HH:mm:ss")); // Example: 2025-07-28 17:45:32

    
        // DateTime Arithmetic
   
        DateTime futureDate = now.AddDays(10); // Add 10 days
        Console.WriteLine("Date after 10 days: " + futureDate.ToString("d")); // Example: 8/7/2025

        DateTime pastDate = now.AddMonths(-2); // Subtract 2 months
        Console.WriteLine("Date 2 months ago: " + pastDate.ToString("d")); // Example: 5/28/2025



        // --------------------------------------------------------------- TimeSpan in C# ------------------------------------------------------------------- //
        
        
        // Create a TimeSpan (2 days, 3 hours, 30 minutes, 15 seconds)
        TimeSpan timeSpan = new TimeSpan(2, 3, 30, 15);
        Console.WriteLine("TimeSpan: " + timeSpan); // Output: 2.03:30:15

        // Get properties of TimeSpan
        Console.WriteLine("Days: " + timeSpan.Days); // 2
        Console.WriteLine("Hours: " + timeSpan.Hours); // 3
        Console.WriteLine("Minutes: " + timeSpan.Minutes); // 30
        Console.WriteLine("Seconds: " + timeSpan.Seconds); // 15
        Console.WriteLine("Milliseconds: " + timeSpan.Milliseconds); // 0

        // Total properties return fractional values
        Console.WriteLine("Total Days: " + timeSpan.TotalDays); // 2.145
        Console.WriteLine("Total Hours: " + timeSpan.TotalHours); // 51.5
        Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // 3090.25

        // Create TimeSpan using static methods
        TimeSpan fromHours = TimeSpan.FromHours(5);
        Console.WriteLine("TimeSpan from 5 hours: " + fromHours); // 05:00:00

        // Add and Subtract TimeSpan
        TimeSpan addedTimeSpan = timeSpan.Add(TimeSpan.FromHours(4));
        Console.WriteLine("TimeSpan after adding 4 hours: " + addedTimeSpan); // 2.07:30:15

        TimeSpan subtractedTimeSpan = timeSpan.Subtract(TimeSpan.FromMinutes(15));
        Console.WriteLine("TimeSpan after subtracting 15 minutes: " + subtractedTimeSpan); // 2.03:15:15

        // Subtract DateTimes to get TimeSpan
        TimeSpan difference = futureDate - now;
        Console.WriteLine("TimeSpan difference: " + difference.TotalDays + " days"); // 10 days
    }
}