// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
class GFG {
    // Main Method
    public static void Main()
    {
        // Console.WriteLine("Waiting for debugger to attach");
        //     while (!System.Diagnostics.Debugger.IsAttached)
        //     {
        //         Thread.Sleep(100);
        //     }
        int age;
        string name;
        Console.WriteLine("Enter your name:? ");
        // using the method
        // typecasting not needed
        // as ReadLine returns string
        name = Console.ReadLine();
        // name = "abc";
        Console.WriteLine("Enter your age: ");
        // Converted string to int
        // age = Convert.ToInt32(Console.ReadLine()); 
        age = 1;
        if (age >= 18)
        {
            Console.WriteLine("Hello " + name + "!"
                        + " You can vote");
        }
        else {
            Console.WriteLine("Hello " + name + "!"
                + " Sorry you can't vote");
        }
    }
}
