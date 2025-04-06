using System;

class Program
{
    static void Main()
    {
        // ---------------------------------------------------------------------- C# String ------------------------------------------------------------------------ //

        // Creating Strings
        string str1 = "Hello, World!"; // Directly using a string literal
        string str2 = new string('A', 5); // Create a string of 'A' repeated 5 times

        Console.WriteLine("str1: " + str1);
        Console.WriteLine("str2: " + str2);
        // Output:
        // str1: Hello, World!
        // str2: AAAAA
 

        // Concatenation of Strings
        string concatenatedStr = str1 + " " + str2; // Use the "+" operator
        Console.WriteLine("Concatenated string: " + concatenatedStr);
        // Output:
        // Concatenated string: Hello, World! AAAAA


        // String Interpolation
        string interpolatedStr = $"{str1} {str2}"; // Interpolation using $ symbol
        Console.WriteLine("Interpolated string: " + interpolatedStr);
        // Output:
        // Interpolated string: Hello, World! AAAAA


        // String Length
        Console.WriteLine("Length of str1: " + str1.Length);
        Console.WriteLine("Length of str2: " + str2.Length);
        // Output:
        // Length of str1: 13
        // Length of str2: 5


        // Accessing Individual Characters
        Console.WriteLine("First character of str1: " + str1[0]);
        Console.WriteLine("Last character of str2: " + str2[str2.Length - 1]);
        // Output:
        // First character of str1: H
        // Last character of str2: A


        // Substring
        string subStr = str1.Substring(7, 5); // Start at index 7 and take 5 characters
        Console.WriteLine("Substring of str1 (from index 7, 5 characters): " + subStr);
        // Output:
        // Substring of str1 (from index 7, 5 characters): World


        // String Comparison
        string str4 = "hello, world!";
        Console.WriteLine("Are str1 and str4 equal (case-sensitive)? " + str1.Equals(str4));
        Console.WriteLine("Are str1 and str4 equal (case-insensitive)? " + str1.Equals(str4, StringComparison.OrdinalIgnoreCase));
        // Output:
        // Are str1 and str4 equal (case-sensitive)? False
        // Are str1 and str4 equal (case-insensitive)? True


        // String to Uppercase and Lowercase
        Console.WriteLine("str1 in uppercase: " + str1.ToUpper());
        Console.WriteLine("str1 in lowercase: " + str1.ToLower());
        // Output:
        // str1 in uppercase: HELLO, WORLD!
        // str1 in lowercase: hello, world!


        // Trimming Spaces
        string str5 = "    Trim me!    ";
        Console.WriteLine("Before trimming: '" + str5 + "'");
        Console.WriteLine("After trimming: '" + str5.Trim() + "'");
        // Output:
        // Before trimming: '    Trim me!    '
        // After trimming: 'Trim me!'


        // Replacing Substrings
        string replacedStr = str1.Replace("World", "CSharp");
        Console.WriteLine("After replacing 'World' with 'CSharp': " + replacedStr);
        // Output:
        // After replacing 'World' with 'CSharp': Hello, CSharp!


        // Splitting a String
        string str6 = "apple,banana,grape";
        string[] fruits = str6.Split(',');
        Console.WriteLine("Splitting str6 by commas:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        // Output:
        // Splitting str6 by commas:
        // apple
        // banana
        // grape


        // Checking if a String Contains a Substring
        Console.WriteLine("Does str3 contain 'C#'? " + str3.Contains("C#"));
        Console.WriteLine("Does str1 contain 'World'? " + str1.Contains("World"));
        // Output:
        // Does str3 contain 'C#'? True
        // Does str1 contain 'World'? True


        // String Format
        int number = 12345;
        string formattedStr = string.Format("The formatted number is: {0:N}", number); // Format with commas
        Console.WriteLine(formattedStr);
        // Output:
        // The formatted number is: 12,345


        // Padding strings
        string paddedStrLeft = str3.PadLeft(20, '*');
        string paddedStrRight = str3.PadRight(20, '*');
        Console.WriteLine("Left padded string: " + paddedStrLeft);
        Console.WriteLine("Right padded string: " + paddedStrRight);
        // Output:
        // Left padded string: *****Welcome to C#
        // Right padded string: Welcome to C#*****


        // Inserting a string
        string insertedStr = str1.Insert(7, "beautiful ");
        Console.WriteLine("After insertion: " + insertedStr);
        // Output:
        // After insertion: Hello, beautiful World!


        // Removing a portion of the string
        string removedStr = str1.Remove(5, 7); // Start from index 5 and remove 7 characters
        Console.WriteLine("After removal: " + removedStr);
        // Output:
        // After removal: Hello!


        // Checking the start of a string
        Console.WriteLine("Does str1 start with 'Hello'? " + str1.StartsWith("Hello"));
        Console.WriteLine("Does str3 start with 'C#'? " + str3.StartsWith("C#"));
        // Output:
        // Does str1 start with 'Hello'? True
        // Does str3 start with 'C#'? False


        // Checking the end of a string
        Console.WriteLine("Does str1 end with 'World!'? " + str1.EndsWith("World!"));
        Console.WriteLine("Does str3 end with 'C#'? " + str3.EndsWith("C#"));
        // Output:
        // Does str1 end with 'World!'? True
        // Does str3 end with 'C#'? True


        // Finding the index of a substring
        Console.WriteLine("Index of 'World' in str1: " + str1.IndexOf("World"));
        Console.WriteLine("Index of 'C#' in str3: " + str3.IndexOf("C#"));
        // Output:
        // Index of 'World' in str1: 7
        // Index of 'C#' in str3: 11


        // Finding the last index of a substring
        string str7 = "apple, banana, apple";
        Console.WriteLine("Last index of 'apple': " + str7.LastIndexOf("apple"));
        // Output:
        // Last index of 'apple': 14
        

        // Joining an array of strings into one string
        string joinedStr = string.Join("-", fruits);
        Console.WriteLine("Joined string: " + joinedStr);
        // Output:
        // Joined string: apple-banana-grape


        // Checking for Empty or Null
        string emptyStr = "";
        string nullStr = null;
        Console.WriteLine("Is str1 empty? " + string.IsNullOrEmpty(str1));
        Console.WriteLine("Is emptyStr empty? " + string.IsNullOrEmpty(emptyStr));
        Console.WriteLine("Is nullStr null? " + string.IsNullOrEmpty(nullStr));
        // Output:
        // Is str1 empty? False
        // Is emptyStr empty? True
        // Is nullStr null? True

        // Using StringBuilder for String Manipulation (Efficient)
        System.Text.StringBuilder sb = new System.Text.StringBuilder("Hello ");
        sb.Append(" World!");
        sb.Insert(6, "C#"); // Insert at index 6
        sb.Replace("C#", "Programming in C#");
        Console.WriteLine("StringBuilder result: " + sb.ToString());
        // Output:
        // StringBuilder result: Hello Programming in C# World!
    }
}
