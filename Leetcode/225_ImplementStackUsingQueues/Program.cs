
MyStack myStack = new MyStack();
myStack.Push(1);
myStack.Push(2);
Console.WriteLine(myStack.Top()); // return 2
Console.WriteLine(myStack.Pop()); // return 2
Console.WriteLine(myStack.Empty()); // return False


public class MyStack
{
    Queue<int> queue;

    public MyStack()
    {
        queue = new Queue<int>();
    }

    public void Push(int x)
    {
        queue.Enqueue(x);

        for (int i = 0; i < queue.Count - 1; i++)
        {
            queue.Enqueue(queue.Dequeue());
        }
    }

    public int Pop()
    {
        return queue.Dequeue();
    }

    public int Top()
    {
        return queue.Peek();
    }

    public bool Empty()
    {
        return queue.Count == 0;
    }
}