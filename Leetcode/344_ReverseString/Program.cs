char[] s = ['h', 'e', 'l', 'l', 'o'];
ReverseString(s);

void ReverseString(char[] s)
{
    int k = s.Length - 1;
    int i = 0;
    
    while(i < k)
    {
        if (s[i] != s[k])
        {
            (s[i], s[k]) = (s[k], s[i]);
        }

        i++;
        k--;
    }

    foreach (var item in s)
    {
        Console.WriteLine(item);
    }
}