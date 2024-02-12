// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
internal class MyStack<T>
{
    public MyStack(int capacity)
    {
        Capacity = capacity;
    }

    public int Capacity { get; }
}