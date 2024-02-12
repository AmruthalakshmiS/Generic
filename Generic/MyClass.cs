using System;

class Stack<T> where T : struct
{
    int capacity;
    private T[] stackArray;
    private int top;
    

    public Stack(int MaxElements)
    {
        capacity = MaxElements;
        stackArray = new T[capacity];
        top = -1;
    }

    public int Push(T item = default(T))
    {
        if (!typeof(T).IsValueType)
        {
            throw new InvalidOperationException("Stack can only contain value types.");
        }

        if (top == stackArray.Length - 1)
        {
            
            if (stackArray.Length >= int.MaxValue / 2)
            {
               
                return -2;
            }
            Console.WriteLine("Stack capacity exceeded");
            Environment.Exit(0);
        }

        if (top == stackArray.Length - 1)
        {
            
            return -1;
        }
        else
        {
            if (EqualityComparer<T>.Default.Equals(item, default))
            {
                item = default(T);
            }
            stackArray[++top] = item;
        }
        return 0;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return stackArray[top--];
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return stackArray[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }
}
