using System;

namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int first, second, result;
            Console.Write("First number: ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 = + Add,\n2 = - Subtract,\n3 = * Multiply");
            
            int operation = Convert.ToInt32(Console.ReadLine());
            if (operation == 1) {
                result = first + second;
                Console.WriteLine(result);
            } else if (operation == 2) {
                result = first - second;
                Console.WriteLine(result);
            } else if (operation == 3) {
                result = first * second;
                Console.WriteLine(result);
            } else {
                Console.WriteLine("try again");
            }
        }
    }
}
