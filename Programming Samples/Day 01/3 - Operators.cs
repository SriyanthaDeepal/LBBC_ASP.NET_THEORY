using System;

class Program
{
    static void Main()
    {
        // ------------------------------------------------------------ C# Operators Demonstration --------------------------------------------------------------- //

        // Arithmetic Operators 
        int a = 10, b = 3;

        Console.WriteLine($"Addition: a + b = {a + b} "); // 10 + 3 = 13
        Console.WriteLine($"Subtraction: a - b = {a - b} "); // 10 - 3 = 7
        Console.WriteLine($"Multiplication: a * b = {a * b} "); // 10 * 3 = 30
        Console.WriteLine($"Division: a / b = {a / b} "); // Integer division, 10 / 3 = 3
        Console.WriteLine($"Modulus: a % b = {a % b} "); // Remainder, 10 % 3 = 1
        a++;
        Console.WriteLine($"Increment: a++ = {a} "); // a becomes 11
        b--;
        Console.WriteLine($"Decrement: b-- = {b} "); // b becomes 2



        // Assignment Operators
        int x = 5;

        x += 3; 
        Console.WriteLine($"x += 3 → {x}"); // x = x + 3 (5 + 3 = 8)
        x -= 2; 
        Console.WriteLine($"x -= 2 → {x}"); // x = x - 2 (8 - 2 = 6)
        x *= 4; 
        Console.WriteLine($"x *= 4 → {x}"); // x = x * 4 (6 * 4 = 24)
        x /= 3; 
        Console.WriteLine($"x /= 3 → {x}"); // x = x / 3 (24 / 3 = 8)
        x %= 2; 
        Console.WriteLine($"x %= 2 → {x}"); // x = x % 2 (8 % 2 = 0)



        // Comparison Operators
        int p = 10, q = 20;
        
        Console.WriteLine($"p == q → {p == q} "); // False (10 != 20)
        Console.WriteLine($"p != q → {p != q} "); // True (10 != 20)
        Console.WriteLine($"p > q → {p > q} "); // False (10 < 20)
        Console.WriteLine($"p < q → {p < q} "); // True (10 < 20)
        Console.WriteLine($"p >= q → {p >= q} "); // False (10 < 20)
        Console.WriteLine($"p <= q → {p <= q} "); // True (10 <= 20)



        // Logical Operators
        bool condition1 = true, condition2 = false;
        Console.WriteLine("\n Logical Operators:");
        Console.WriteLine($"condition1 && condition2 → {condition1 && condition2} "); // False
        Console.WriteLine($"condition1 || condition2 → {condition1 || condition2} "); // True
        Console.WriteLine($"!condition1 → {!condition1} "); // False



        // Bitwise Operators 
        int bitA = 5, bitB = 3; // 5 = 0101, 3 = 0011
        Console.WriteLine("\n Bitwise Operators:");
        Console.WriteLine($"bitA & bitB → {bitA & bitB} "); // 0101 & 0011 = 0001 (1)
        Console.WriteLine($"bitA | bitB → {bitA | bitB} "); // 0101 | 0011 = 0111 (7)
        Console.WriteLine($"bitA ^ bitB → {bitA ^ bitB} "); // 0101 ^ 0011 = 0110 (6)
        Console.WriteLine($"~bitA → {~bitA} "); // Bitwise NOT (~0101) = -6
        Console.WriteLine($"bitA << 1 → {bitA << 1} "); // Left Shift (0101 << 1) = 1010 (10)
        Console.WriteLine($"bitA >> 1 → {bitA >> 1} "); // Right Shift (0101 >> 1) = 0010 (2)



        // Ternary Operator
        int age = 18;
        string eligibility = (age >= 18) ? "Eligible to vote" : "Not eligible";
        Console.WriteLine("\n Ternary Operator:");
        Console.WriteLine($"Age = {age}, Result = {eligibility} "); // Eligible to vote



        //  Null-Coalescing Operators (??, ??=)
        string? nullString = null;
        string defaultString = nullString ?? "Default Value";
        Console.WriteLine("\n Null-Coalescing Operators:");
        Console.WriteLine($"nullString ?? 'Default Value' = {defaultString}"); // Default Value

        int? nullableInt = null;
        nullableInt ??= 100;
        Console.WriteLine($"nullableInt ??= 100 → {nullableInt}"); // 100

        //  Type Checking Operators (is, as, typeof)
        object obj1 = "Hello";
        object obj2 = 123;

        Console.WriteLine($"obj1 is string → {obj1 is string} "); // True
        Console.WriteLine($"obj2 is int → {obj2 is int} "); // True

        object obj3 = "Casting Test";
        string? castedStr = obj3 as string;
        Console.WriteLine($"obj3 as string → {castedStr} "); // Casting Test
        Console.WriteLine($"typeof(int) → {typeof(int)} "); // System.Int32
        Console.WriteLine($"typeof(double) → {typeof(double)} "); // System.Double

    }
}
