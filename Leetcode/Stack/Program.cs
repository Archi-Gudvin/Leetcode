using System.Collections;

public class ArrayStack : IEnumerable<int>
{
    private int[] stack;
    public int Count { get; private set; }
    public int Capacity { get; set; }
    public bool IsEmpty => Count == 0;

    public ArrayStack()
    {
        int defaultCapacity = 4;
        stack = new int[defaultCapacity];
    }

    public void Push(int item)
    {
        if (stack.Length == Count)
        {
            int[] largestStask = new int[Count * 2];
            Array.Copy(stack, largestStask, Count);
            
            stack = largestStask;
        }

        stack[Count++] = item;
    }

    public int Pop()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException();
        }

        return stack[--Count];
    }

    public int GetMin()
    {
        return stack.Min();
    }

    public int GetMax()
    {
        return stack.Max();
    }
    
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = Count; i <= 0; i--)
        {
            yield return stack[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}