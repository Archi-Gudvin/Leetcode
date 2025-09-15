string s = "abbaca";

Console.WriteLine(RemoveDuplicates(s));

string RemoveDuplicates(string s)
{
    Stack<char> stack = new();
    
    stack.Push(s[0]);

    int i = 1;

    while (i < s.Length)
    {
        char temp = ' ';
        
        if (stack.Count != 0)
        {
            temp = stack.Peek();
        }
        
        if (s[i] != temp || temp == ' ')
        {
            stack.Push(s[i]);
        }
        else
        {
            stack.Pop();
        }

        i++;
    }

    return string.Join("", stack.Reverse());
}