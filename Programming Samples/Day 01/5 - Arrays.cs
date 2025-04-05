using System;

class Program
{
    static void Main()
    {
        // -------------------------------------------------------------- C# Arrays Overview ---------------------------------------------------------------------- //

        // Single-Dimensional Array

        int[] intArray = new int[5]; // Declaring and initializing a single-dimensional array
        intArray[0] = 1; // Assigning values to the array
        intArray[1] = 2;
        intArray[2] = 3;
        intArray[3] = 4;
        intArray[4] = 5;

        // Accessing and printing elements
        Console.WriteLine("Elements of intArray:");
        foreach (var item in intArray)
        {
            Console.WriteLine(item);
        }
        // Output:
        // Elements of intArray:
        // 1
        // 2
        // 3
        // 4
        // 5



        // 2. Multidimensional Array

        int[,] multiArray = new int[2, 2] { { 1, 2 }, { 3, 4 } };

        // Accessing elements of a 2D array
        Console.WriteLine("Elements of multiArray:");
        for (int i = 0; i < multiArray.GetLength(0); i++) // GetLength(0) gives number of rows
        {
            for (int j = 0; j < multiArray.GetLength(1); j++) // GetLength(1) gives number of columns
            {
                Console.WriteLine($"multiArray[{i},{j}] = {multiArray[i, j]}");
            }
        }
        // Output:
        // Elements of multiArray:
        // multiArray[0,0] = 1
        // multiArray[0,1] = 2
        // multiArray[1,0] = 3
        // multiArray[1,1] = 4



        // Array Length, Lower Bound, and Upper Bound
        Console.WriteLine("Length of intArray: " + intArray.Length);
        Console.WriteLine("Lower Bound of intArray (dimension 0): " + intArray.GetLowerBound(0));
        Console.WriteLine("Upper Bound of intArray (dimension 0): " + intArray.GetUpperBound(0));
        // Output:
        // Length of intArray: 5
        // Lower Bound of intArray (dimension 0): 0
        // Upper Bound of intArray (dimension 0): 4




        // ------------------------------------------------ Array Manipulation Methods --------------------------------------------------------

        // Array Initialization with values
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Original array: " + string.Join(", ", numbers));
        // Output:
        // Original array: 10, 20, 30, 40, 50


        // Array.Sort: Sorts the array
        Array.Sort(numbers);
        Console.WriteLine("Array after sorting: " + string.Join(", ", numbers));
        // Output:
        // Array after sorting: 10, 20, 30, 40, 50 (already sorted)


        // Array.Reverse: Reverses the array
        Array.Reverse(numbers);
        Console.WriteLine("Array after reversing: " + string.Join(", ", numbers));
        // Output:
        // Array after reversing: 50, 40, 30, 20, 10


        // Array.Clear: Clears/ Sets to default a part of an array
        Array.Clear(numbers, 0, 2);
        Console.WriteLine("Array after clearing first 2 elements: " + string.Join(", ", numbers));
        // Output:
        // Array after clearing first 2 elements: 0, 0, 30, 20, 10


        // Array.IndexOf: Finds the index of an element
        int index = Array.IndexOf(numbers, 40);
        Console.WriteLine("Index of 40 in numbers array: " + index);
        // Output:
        // Index of 40 in numbers array: 3


        // Array.LastIndexOf: Finds the last index of an element
        int lastIndex = Array.LastIndexOf(numbers, 40);
        Console.WriteLine("Last index of 40 in numbers array: " + lastIndex);
        // Output:
        // Last index of 40 in numbers array: 3


        // Array Length and Dimensions
        Console.WriteLine("Length of numbers array: " + numbers.Length); // Length of a single-dimensional array
        // Output:
        // Length of numbers array: 5
        

        // Array Find Methods
        int foundValue = Array.Find(numbers, element => element > 30); // Finds first element greater than 30
        Console.WriteLine("First element greater than 30: " + foundValue);
        // Output:
        // First element greater than 30: 30


        int[] allGreaterThan20 = Array.FindAll(numbers, element => element > 20); // Finds all elements greater than 20
        Console.WriteLine("All elements greater than 20: " + string.Join(", ", allGreaterThan20));
        // Output:
        // All elements greater than 20: 30, 20, 10


        // Using Array.ForEach
        Console.WriteLine("Using Array.ForEach to print each element:");
        Array.ForEach(numbers, Console.WriteLine);
        // Output:
        // Using Array.ForEach to print each element:
        // 0
        // 0
        // 30
        // 20
        // 10

    }
}
