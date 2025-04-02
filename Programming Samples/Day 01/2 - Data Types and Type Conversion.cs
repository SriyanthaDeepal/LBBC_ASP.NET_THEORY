using System; 

class Program
{
    static void Main()
    {
        // ------------------------------------------------- C# Data Types and Type Casting Demonstration ------------------------------------------------------------ //

        // Integer Data Types
        sbyte sbyteVal = -128;  // 8-bit signed integer (-128 to 127)
        byte byteVal = 255;  // 8-bit unsigned integer (0 to 255)
        short shortVal = -32768; // 16-bit signed integer (-32,768 to 32,767)
        ushort ushortVal = 65535; // 16-bit unsigned integer (0 to 65,535)
        int intVal = -2147483648; // 32-bit signed integer (-2^31 to 2^31-1)
        uint uintVal = 4294967295; // 32-bit unsigned integer (0 to 2^32-1)
        long longVal = -9223372036854775808L; // 64-bit signed integer (-2^63 to 2^63-1)
        ulong ulongVal = 18446744073709551615UL; // 64-bit unsigned integer (0 to 2^64-1)

        // Floating Point Data Types
        float floatVal = 3.1415927f; // 32-bit floating point (7 digits precision)
        double doubleVal = 3.141592653589793; // 64-bit floating point (15-16 digits precision)
        decimal decimalVal = 3.1415926535897932384626433832m; // 128-bit decimal (28-29 digits, best for finance)

        // Character Data Type
        char charVal = 'A'; // Stores a single Unicode character

        // Boolean Data Type
        bool boolVal = true; // Stores true or false

        // String Data Type
        string stringVal = "Hello, C# World!"; // Sequence of characters

        // Object Data Type (Base Type of All)
        object objectVal = 42; // Can store any data type

        // Nullable Data Type (Allows null values)
        int? nullableInt = null; // Can hold an integer or null

        // Verbatim String (Preserves formatting)
        string verbatimString = @"C:\Users\MyPC\Documents\file.txt"; // Useful for file paths



        // ------------------------------------------------------------- TYPE CASTING -------------------------------------------------------------------------------- //

        // Implicit Casting (Automatic and Safe)
        int smallInt = 100;
        long largerLong = smallInt;  // int to long
        float floatNum = largerLong; // long to float
        Console.WriteLine($"Implicit Casting: int → long → float: {floatNum}");

        // Explicit Casting (Manual and Risky)
        double bigDouble = 1234.5678;
        int forcedInt = (int)bigDouble; // Double to int (Loses decimal)
        Console.WriteLine($"Explicit Casting: double → int: {forcedInt}");

        // Using Convert Class (Handles conversion safely)
        string strNum = "12345";
        int convertedInt = Convert.ToInt32(strNum);
        Console.WriteLine($"Convert Class: string → int: {convertedInt}");

        // Parsing (Converts string to number)
        string decimalStr = "45.67";
        float parsedFloat = float.Parse(decimalStr);
        Console.WriteLine($"Parsing: string → float: {parsedFloat}");

        // TryParse (Safe Parsing to Avoid Errors)
        string invalidInput = "abc";
        bool success = int.TryParse(invalidInput, out int result);
        Console.WriteLine($"TryParse: \"abc\" → int? Success: {success}, Value: {result}");

        // Boxing (Storing a value type inside an object)
        int boxVal = 42;
        object boxed = boxVal;
        int unboxed = (int)boxed;
        Console.WriteLine($"Boxing & Unboxing: {boxed} → {unboxed}");


        //  User Input Demonstration
        Console.WriteLine("\n--- User Input Section ---\n");

        Console.Write("Enter an integer: ");
        int userInt = Convert.ToInt32(Console.ReadLine()); // Read and convert input to integer

        Console.Write("Enter a floating-point number: ");
        float userFloat = float.Parse(Console.ReadLine()); // Convert input to float

        Console.Write("Enter a decimal number: ");
        decimal userDecimal = decimal.Parse(Console.ReadLine()); // Convert input to decimal

        Console.Write("Enter a character: ");
        char userChar = Console.ReadLine()[0]; // Read single character

        Console.Write("Enter a boolean value (true/false): ");
        bool userBool = Convert.ToBoolean(Console.ReadLine()); // Convert input to boolean

        Console.Write("Enter a string: ");
        string userString = Console.ReadLine(); // Read string input

    }
}
