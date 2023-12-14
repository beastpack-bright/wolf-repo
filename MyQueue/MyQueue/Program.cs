using System;
using System.Collections.Generic;

class MyQueue
{
    private List<int> queueList;

    public MyQueue()
    {
        queueList = new List<int>();
    }
    //enqueue 
    public void Enqueue(int n)
    {
        queueList.Add(n);
    }
    //dequeue 
    public int Dequeue()
    {//error handling
        if (queueList.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty, cannot dequeue.");
        }

        int dequeuedItem = queueList[0];
        queueList.RemoveAt(0); //removing 
        return dequeuedItem;
    }
    //peeking 
    public int Peek()
    {
        if (queueList.Count == 0)
        { //error handling
            throw new InvalidOperationException("Queue is empty, cannot peek.");
        }

        return queueList[0];
    }
}

class Program
{
    static void Main()
    {
        // Example usage, testing with simple numbers
        MyQueue myQueue = new MyQueue();

        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);

        Console.WriteLine("Peek: " + myQueue.Peek()); // 1

        Console.WriteLine("Dequeue: " + myQueue.Dequeue()); //  1
        Console.WriteLine("Dequeue: " + myQueue.Dequeue()); // 2

        myQueue.Enqueue(4);
        Console.WriteLine("Peek: " + myQueue.Peek()); //  3
    } //success!
}
