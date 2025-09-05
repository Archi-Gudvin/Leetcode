string s = "]";

Console.WriteLine(IsValid(s));


bool IsValid(string s)
{
    if (s.Length % 2 != 0)
    {
        return false;
    }
    
    Stack<char> stack = new Stack<char>();

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '[' || s[i] == '{' || s[i] == '(')
        {
            stack.Push(s[i]);
            continue;
        }

        if (s[i] == ']' || s[i] == '}' || s[i] == ')')
        {
            if (stack.Count == 0)
            {
                return false;
            }
            
            var temp = stack.Peek();

            var isValid = FindChar(s[i], temp);

            if (!isValid)
            {
                return false;
            }
            else
            {
                stack.Pop();
            }
        }
    }

    return stack.Count != 0 ? false : true;
}

bool FindChar(char value, char searchValue)
{
    bool result = false;
    
    switch (value)
    {
        case '}' :
            if (searchValue == '{')
            {
                result = true;
            }
            break;
        case ']' :
            if (searchValue == '[')
            {
                result = true;
            }
            break;
        case ')':
            if (searchValue == '(')
            {
                result = true;
            }
            break;
    }

    return result;
}