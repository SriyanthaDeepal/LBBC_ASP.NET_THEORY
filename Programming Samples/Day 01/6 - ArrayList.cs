using System;
using System.Collections; // Required for ArrayList

class Program
{
    static void Main()
    {
        // ---------------------------------------------------------------- C# ArrayList Overview ----------------------------------------------------------------- //

        // Creating an ArrayList
        ArrayList arrayList = new ArrayList();

        // Adding elements to the ArrayList
    
        arrayList.Add(10); // Add an integer
        arrayList.Add("Hello"); // Add a string
        arrayList.Add(3.14); // Add a double
        arrayList.Add(true); // Add a boolean
        arrayList.Add(new DateTime(2020, 1, 1)); // Add a DateTime object

        // Output ArrayList elements
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        // 10
        // Hello
        // 3.14
        // True
        // 1/1/2020 12:00:00 AM


        // Accessing elements from ArrayList
        Console.WriteLine("Element at index 1: " + arrayList[1]); // Access by index
        // Output:
        // Element at index 1: Hello
        

        // Checking the ArrayList Count (number of elements)
        Console.WriteLine("Number of elements in ArrayList: " + arrayList.Count);
        // Output:
        // Number of elements in ArrayList: 5

        // Inserting an element at a specific index
        arrayList.Insert(2, "Inserted at index 2");

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        // Output:
        // ArrayList after inserting an element at index 2:
        // 10
        // Hello
        // Inserted at index 2
        // 3.14
        // True
        // 1/1/2020 12:00:00 AM


        // Removing an element by value
        arrayList.Remove("Hello");

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        // Output:
        // ArrayList after removing 'Hello':
        // 10
        // Inserted at index 2
        // 3.14
        // True
        // 1/1/2020 12:00:00 AM


        // Removing an element by index
        arrayList.RemoveAt(3); // Remove element at index 3

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        // Output:
        // ArrayList after removing element at index 3:
        // 10
        // Inserted at index 2
        // 3.14
        // 1/1/2020 12:00:00 AM


        // Checking if an element exists in the ArrayList
        Console.WriteLine("Contains 10: " + arrayList.Contains(10));
        // Output:
        // Contains 10: True


        // Finding the index of an element
        int index = arrayList.IndexOf(3.14);
        Console.WriteLine("Index of 3.14: " + index);
        // Output:
        // Index of 3.14: 2


        // Clear all elements in the ArrayList
        arrayList.Clear();
        Console.WriteLine("ArrayList Count: " + arrayList.Count);
        // Output:
        // ArrayList after clearing all elements:
        // ArrayList Count: 0


        // Using ArrayList with a different data type
        ArrayList stringArrayList = new ArrayList();
        stringArrayList.Add("Apple");
        stringArrayList.Add("Banana");
        stringArrayList.Add("Cherry");

        Console.WriteLine("stringArrayList contains:");
        foreach (var item in stringArrayList)
        {
            Console.WriteLine(item);
        }
        // Output:
        // stringArrayList contains:
        // Apple
        // Banana
        // Cherry


        // Checking if an element is present using Contains
        Console.WriteLine("Contains 'Banana': " + stringArrayList.Contains("Banana"));
        // Output:
        // Contains 'Banana': True


        // Using the ArrayList ToArray method to convert to an array
        object[] arrayFromList = (object[])stringArrayList.ToArray(typeof(object));
        Console.WriteLine("Converted array:");
        foreach (var item in arrayFromList)
        {
            Console.WriteLine(item);
        }
        // Output:
        // Converted array:
        // Apple
        // Banana
        // Cherry


        // Using ArrayList's Sort method
        stringArrayList.Sort();
        Console.WriteLine("Sorted stringArrayList:");
        foreach (var item in stringArrayList)
        {
            Console.WriteLine(item);
        }
        // Output:
        // Sorted stringArrayList:
        // Apple
        // Banana
        // Cherry


        // Using ArrayList's Reverse method
        stringArrayList.Reverse();
        Console.WriteLine("Reversed stringArrayList:");
        foreach (var item in stringArrayList)
        {
            Console.WriteLine(item);
        }
        // Output:
        // Reversed stringArrayList:
        // Cherry
        // Banana
        // Apple
    }
}
