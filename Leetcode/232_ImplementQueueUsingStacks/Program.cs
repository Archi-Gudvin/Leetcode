MyQueue obj = new MyQueue();
int x1 = 1;
int x2 = 2;
obj.Push(x1);
obj.Push(x2);
int param_2 = obj.Pop();
int param_3 = obj.Peek();
bool param_4 = obj.Empty();

public class MyQueue
{
    public Stack<int> stack1;
    public Stack<int> stack2;


    public MyQueue()
    {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }

    public void Push(int x)
    {
        while (stack2.Count > 0)
        {
            stack1.Push(stack2.Pop());
        }

        stack1.Push(x);

        while (stack1.Count > 0)
        {
            stack2.Push(stack1.Pop());
        }
    }

    public int Pop()
    {
        return stack2.Pop();
    }

    public int Peek()
    {
        return stack2.Peek();
    }

    public bool Empty()
    {
        return stack2.Count == 0;
    }
}