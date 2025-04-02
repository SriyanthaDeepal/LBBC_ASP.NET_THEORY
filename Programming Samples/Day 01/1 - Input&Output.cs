using System;

class Program
{
    static void Main()
    {
        // ---------------------------------------------------- User Inputs ------------------------------------------------------------ //

        /* We use "Console.ReadLine()" for get user inputs
           This one always get user input as a string */
        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();

        /* Because user input is get as a string,
           We have to use "Convert.ToInt32()" for convert a string to int */
        Console.Write("\nEnter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());

        // We use "Convert.ToDouble()" for convert a string to double
        Console.Write("Enter your height in meters (e.g., 1.75): ");
        double height = Convert.ToDouble(Console.ReadLine());

        // We use "Convert.ToBoolean()" for convert a string to boolean
        Console.Write("Are you a student (true/false): ");
        bool isStudent = Convert.ToBoolean(Console.ReadLine());

        // We use "Convert.ToSingle()" for convert a string to float
        Console.Write("Enter a floating-point number (e.g., 3.14): ");
        float floatNumber = Convert.ToSingle(Console.ReadLine());

        //We use "Convert.ToDecimal()" for convert a string to decimal
        Console.Write("Enter a decimal number (e.g., 12.34): ");
        decimal decimalNumber = Convert.ToDecimal(Console.ReadLine());

        // Here we using "[0]", we say that only to get the first character of the string
        Console.Write("Enter a character: ");
        char character = Console.ReadLine()[0];


        // -------------------------------------------------- OUTPUT ----------------------------------------------------------------------- //

        // Standard output with a new line
        Console.WriteLine("Hello, World!"); 

        // Output without a new line
        Console.Write("This is "); 

        // Output with escape characters
        Console.Write("a demonstration of output methods.\n");

        // Output with formatted strings
        int age = 25;
        string name = "John";
        Console.WriteLine("Name: {0}, Age: {1}", name, age); // Using placeholders for variables
        Console.WriteLine($"Name: {name}, Age: {age}"); // String interpolation


        // We can directly output variables without using formatting
        Console.WriteLine("\n--- Direct Output of Variables ---");
        Console.WriteLine(fullName); // Output string variable
        Console.WriteLine(userAge);  // Output integer variable
        Console.WriteLine(height);   // Output double variable
        Console.WriteLine(isStudent); // Output boolean variable
        Console.WriteLine(floatNumber); // Output float variable
        Console.WriteLine(decimalNumber); // Output decimal variable
        Console.WriteLine(character); // Output char variable

        // Verbatim string example
        // This allow include multiple lines without including escape characters
        string verbatimString = @"This is a verbatim string.
It can span multiple lines without needing escape sequences like \n or \t.
For example, here is a file path: C:\Users\Name\Documents.";

        Console.WriteLine("\n--- Verbatim String ---");
        Console.WriteLine(verbatimString);

        

        // ------------------------------------------------------- Reading Keypress -------------------------------------------------------------- //

        // Read a key press
        // Capture the individual key press from the user
        Console.WriteLine("\nPress any key to continue...");
        ConsoleKeyInfo keyInfo = Console.ReadKey(); // Capture key press

        // "keyInfo.Key" provides the key enumeration value (e.g.: ConsoleKey.A)
        Console.WriteLine($"\nYou pressed the key: {keyInfo.Key}");

        // "keyInfor.KeyChar provides the character of the key pressed
        Console.WriteLine($"Key character: {keyInfo.KeyChar}");
    }
}
