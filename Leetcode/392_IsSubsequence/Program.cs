string s = "abc", t = "ahbgd";

Console.WriteLine(IsSubsequence(s, t));

bool IsSubsequence(string s, string t)
{
    int j = 0;
    int i = 0;
    int count = 0;

    while (j < s.Length && i < t.Length)
    {
        for (int g = i; g < t.Length; g++)
        {
            if (s[j] == t[g])
            {
                count++;
                i++;
                break;
            }

            i++;
        }

        j++;
    }

    return count == s.Length;
}