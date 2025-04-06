using System;

class MethodsDemo
{
    // Instance Method (requires an object to call)
    // These methods belong to an instance of a class and require an object to be called.
    public void InstanceMethod()
    {
        Console.WriteLine("This is an instance method.");
    }


    // Static Method (can be called without an object)
    // Static methods belong to the class itself rather than an instance and can be called without creating an object.
    public static void StaticMethod()
    {
        Console.WriteLine("This is a static method.");
    }


    // Method with Value Parameter
    // The value of the parameter is passed by value, meaning changes inside the method do not affect the original variable.
    public void ValueParameterMethod(int number)
    {
        number *= 2; // Changes will not reflect outside this method
        Console.WriteLine("Inside method (value parameter): " + number);
    }


    // Method with Ref Parameter (modifies original variable)
    // 'ref' allows a method to modify the original value of the argument passed.
    // The variable must be initialized before being passed as a ref parameter.
    public void RefParameterMethod(ref int number)
    {
        number *= 2; // Changes will reflect outside this method
    }


    // Method with Out Parameter (must be assigned inside method)
    // 'out' is used when a method needs to return multiple values.
    // The variable passed as an out parameter does not need to be initialized before passing it.
    public void OutParameterMethod(out int result)
    {
        result = 100; // Must assign a value before returning
    }


    // Method with In Parameter (readonly, prevents modification)
    // 'in' is used to ensure that the parameter is read-only inside the method.
    // This prevents accidental modifications.
    public void InParameterMethod(in int number)
    {
        Console.WriteLine("In parameter value: " + number);
    }


    // Method with Default Parameter
    // If no argument is provided, the default value is used.
    public void DefaultParameterMethod(int num = 10)
    {
        Console.WriteLine("Default parameter value: " + num);
    }


    // Method with Named Parameters
    // Named parameters allow specifying arguments by name, making the call more readable.
    public void NamedParameterMethod(string firstName, string lastName)
    {
        Console.WriteLine("Full Name: " + firstName + " " + lastName);
    }

    // Method with Variable-length Parameters (params)
    // 'params' allows passing a variable number of arguments of the same type.
    public void ParamsMethod(params int[] numbers)
    {
        Console.WriteLine("Total Numbers: " + numbers.Length);
    }


    // Method Overloading (same name, different parameters)
    // Overloading allows multiple methods with the same name but different parameter lists.
    public void Print(int num) => Console.WriteLine("Number: " + num);
    public void Print(string text) => Console.WriteLine("Text: " + text);


    // Recursive Method (calls itself)
    // Recursion is a technique where a method calls itself to solve a problem.
    public int Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }


    // Local Function (function inside a method)
    // Local functions are nested functions that help in better code organization.
    public void LocalFunctionExample()
    {
        void InnerFunction()
        {
            Console.WriteLine("This is a local function.");
        }
        InnerFunction();
    }


    // Expression-bodied Method (single-line methods)
    // A concise way to define methods with a single return expression.
    public int Square(int num) => num * num;


    // Anonymous Method (using delegate)
    // Anonymous methods are unnamed methods assigned to delegates.
    public delegate void AnonymousDelegate(string message);


    // Asynchronous Method (using async & await)
    // Asynchronous methods allow non-blocking execution for better performance.
    public async System.Threading.Tasks.Task AsyncMethod()
    {
        await System.Threading.Tasks.Task.Delay(1000); // Simulates delay
        Console.WriteLine("Asynchronous method finished.");
    }

    static void Main()
    {
        MethodsDemo obj = new MethodsDemo();

        // Instance method
        obj.InstanceMethod(); // Output: This is an instance method.

        // Static method
        StaticMethod(); // Output: This is a static method.

        // Value parameter
        int val = 5;
        obj.ValueParameterMethod(val);
        Console.WriteLine("Outside method (value parameter): " + val); // No change

        // Ref parameter
        obj.RefParameterMethod(ref val);
        Console.WriteLine("Outside method (ref parameter): " + val); // Value doubled

        // Out parameter
        int result;
        obj.OutParameterMethod(out result);
        Console.WriteLine("Out parameter result: " + result); // Output: 100

        // In parameter
        obj.InParameterMethod(val);

        // Default parameter
        obj.DefaultParameterMethod(); // Uses default value 10
        obj.DefaultParameterMethod(25); // Overrides default value

        // Named parameter
        obj.NamedParameterMethod(lastName: "Doe", firstName: "John");

        // Params parameter
        obj.ParamsMethod(1, 2, 3, 4, 5);

        // Method overloading
        obj.Print(42);
        obj.Print("Hello");

        // Returning multiple values
        var tupleResult = obj.GetTuple();
        Console.WriteLine("Tuple values: " + tupleResult.Item1 + ", " + tupleResult.Item2);

        // Recursive method
        Console.WriteLine("Factorial of 5: " + obj.Factorial(5)); // Output: 120

        // Local function
        obj.LocalFunctionExample();

        // Expression-bodied method
        Console.WriteLine("Square of 6: " + obj.Square(6));

        // Extension method
        "Hello, World!".PrintLength(); // Uses extension method

        // Anonymous method
        AnonymousDelegate anonMethod = delegate (string msg) { Console.WriteLine("Anonymous: " + msg); };
        anonMethod("Test Message");

        // Asynchronous method
        obj.AsyncMethod().Wait();
    }
}
