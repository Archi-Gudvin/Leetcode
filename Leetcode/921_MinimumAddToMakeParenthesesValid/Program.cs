string s = "()))((";

Console.WriteLine(MinAddToMakeValid(s));


int MinAddToMakeValid(string s)
{
    int openBracet = 0, match = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(')
        {
            openBracet++;
        }
        else
        {
            if (openBracet > 0)
            {
                openBracet--;
            }
            else
            {
                match++;
            }
        }
    }

    return openBracet + match;
}