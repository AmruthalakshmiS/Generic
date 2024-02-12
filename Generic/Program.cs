using System;

class Program
{
    static void Main(string[] args)
    {
        //Stack<int> valueStack = new Stack<int>();

        int capacity;
        Console.WriteLine("Enter capactiy of Stack");
        capacity = int.Parse(Console.ReadLine());

        Stack<int> valueStack = new Stack<int>(capacity);

        while (true)
        {
            Console.WriteLine("\nEnter your choice:");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Check if empty");
            Console.WriteLine("5. Exit");

            int choice;
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter value to push:");
                    int value;
                    if (!int.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Invalid input. Please enter a value type.");
                        continue;
                    }
                    
                    valueStack.Push(value);
                    Console.WriteLine("Value {0} pushed onto the stack.", value);
                    break;
                case 2:
                    try
                    {
                        int poppedItem = valueStack.Pop();
                        Console.WriteLine("Popped item is " + poppedItem);
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Peek: " + valueStack.Peek());
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    Console.WriteLine("Stack is empty => " + valueStack.IsEmpty());
                    break;
                case 5:
                    Console.WriteLine("Exiting program.");
                    Environment.Exit(0);
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option (1-5).");
                    break;
            }
        }

    }
}
       
    
