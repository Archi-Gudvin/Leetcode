string s = "a#c", t = "b";

Console.WriteLine(BackspaceCompare(s, t));

bool BackspaceCompare(string s, string t)
{
        Stack<char> stack = new Stack<char>();

        string resS = Srt(s, stack);
        
        stack.Clear();
        
        string resT = Srt(t, stack);
        
        return resS == resT;
}

string Srt(string val, Stack<char> stack)
{
        string result = "";
        
        for (int i = 0; i < val.Length; i++)
        {
                if (val[i] != '#')
                {
                        stack.Push(val[i]);  
                }
                else
                {
                        if (stack.Count != 0)
                        {
                                stack.Pop();
                        }
                }
        }
        
        foreach (var item in stack)
        {
                result += item;
        }

        return result;
}