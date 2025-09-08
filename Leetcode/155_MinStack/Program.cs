
MinStack minStack = new MinStack();
minStack.Push(2);
minStack.Push(0);
minStack.Push(3);
minStack.Push(0);

int a = minStack.GetMin();

minStack.Pop();
int b = minStack.GetMin(); 

minStack.Pop();
int c = minStack.GetMin(); 

minStack.Pop();
int x = minStack.GetMin(); 


int all0 = 0;

public class MinStack
{
    public Stack<int> stack;

    public int Count { get; private set; }
    
    public MinStack()
    {
        int defaultCapasity = 4;
        stack = new Stack<int>(defaultCapasity);
    }
    
    public void Push(int val) {
       stack.Push(val);
       Count++;
    }
    
    public void Pop()
    {
        stack.Pop();
        Count--;
    }
    
    public int Top()
    {
        return stack.Peek();
    }
    
    public int GetMin()
    {
        return stack.Take(Count).Min();
    }
}


  