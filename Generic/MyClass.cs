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

    public void Push(T item = default(T))
    {
        if (!typeof(T).IsValueType)
        {
            throw new InvalidOperationException("Stack can only contain value types.");
        }

        if (top == stackArray.Length - 1)
        {
            Array.Resize(ref stackArray, stackArray.Length * 2);
        }

        stackArray[++top] = item;
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
