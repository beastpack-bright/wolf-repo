using System;
using System.Collections.Generic;

class MyStack
{
    private List<int> stackList;

    public MyStack()
    {
        stackList = new List<int>();
    }
    //pushing 
    public void Push(int n)
    {
        stackList.Add(n);
    }

    //popping 
    public int Pop()
    {
        if (stackList.Count == 0)
        {//error handling
            throw new InvalidOperationException("Stack is empty, cannot pop.");
        }

        int poppedItem = stackList[stackList.Count - 1];
        stackList.RemoveAt(stackList.Count - 1);
        return poppedItem;
    }

    public int Peek()
    {//error handling
        if (stackList.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty, cannot peek.");
        }

        return stackList[stackList.Count - 1];
    }
}

class Program
{
    static void Main()
    {
        //example usage using basic numbers (testing) 
        MyStack myStack = new MyStack();
       
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);

        Console.WriteLine("Peek: " + myStack.Peek()); //3 

        Console.WriteLine("Pop: " + myStack.Pop());   // 3
        Console.WriteLine("Pop: " + myStack.Pop());   // 2

        myStack.Push(4);
        Console.WriteLine("Peek: " + myStack.Peek()); // 4
    }
    //success! 
}
