using System;

class Program {
    static void Main() {
        int a, b;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        Console.WriteLine(a + b);
    }
}
// using System;

// class Program
// {
//     static void Main()
//     {
//         int a = ReadInput("Enter the first number: ");
//         int b = ReadInput("Enter the second number: ");
//         Console.WriteLine($"The sum is: {a + b}");
//     }

//     static int ReadInput(string prompt)
//     {
//         Console.Write(prompt);
//         return int.Parse(Console.ReadLine());
//     }
// }
