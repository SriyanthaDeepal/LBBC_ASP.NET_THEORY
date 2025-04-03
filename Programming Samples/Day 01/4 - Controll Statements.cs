using System;

class Program
{
    static void Main()
    {
        // ---------------------------------------------------------------- C# Control Statements ------------------------------------------------------------------ //

        // ------------------- Selection Statements (Conditional Execution) ----------------------------------

        int num = 10;
        
        // if Statement
        if (num > 5)
        {
            Console.WriteLine("if: Number is greater than 5");
        }


        // if-else Statement
        if (num % 2 == 0)
        {
            Console.WriteLine("if-else: Number is even");
        }
        else
        {
            Console.WriteLine("if-else: Number is odd");
        }


        // switch Statement
        int day = 3;
        switch (day)
        {
            case 1:
                Console.WriteLine("switch: Monday");
                break;
            case 2:
                Console.WriteLine("switch: Tuesday");
                break;
            case 3:
                Console.WriteLine("switch: Wednesday");
                break;
            default:
                Console.WriteLine("switch: Other day");
                break;
        }





        // ------------------------------------- Iteration Statements (Loops) ----------------------------------------------

        Console.WriteLine("\n Iteration Statements:");


        // for Loop
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i + " ");
        }


        // foreach Loop
        int[] numbers = { 1, 2, 3, 4, 5 };

        foreach (int n in numbers)
        {
            Console.Write(n + " ");
        }


        // while Loop
        int count = 1;

        while (count <= 5)
        {
            Console.Write(count + " ");
            count++;
        }


        // do-while Loop
        int j = 1;

        do
        {
            Console.Write(j + " ");
            j++;
        } while (j <= 5);


        // -------------------------------------------------------- Jump Statements (Flow Control) ---------------------------------------------------------------

        // break Statement
        for (int k = 1; k <= 10; k++)
        {
            if (k == 6) break; // Stops at 6
            Console.Write(k + " ");
        }


        // continue Statement
        Console.Write("continue in loop: ");
        for (int k = 1; k <= 5; k++)
        {
            if (k == 3) continue; // Skips 3
            Console.Write(k + " ");
        }

        // return Statement
        Console.WriteLine("\n Calling Function with return statement:");
        int result = Add(5, 10);
        Console.WriteLine($"return: Sum of 5 and 10 is {result}");
    }

    static int Add(int a, int b)
    {
        return a + b; // return statement to send value back
    }
}
