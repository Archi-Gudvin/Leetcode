string s = "cbbcc";

Console.WriteLine(ValidPalindrome(s));

bool ValidPalindrome(string s)
{
    if (s.Equals(string.Concat(s.Reverse())))
    {
        return true;
    }

    int left = 0;
    int right = s.Length - 1;
    
    while (left < right)
    {
        if (s[left] != s[right])
        {
            return IsPalindrome(s, left + 1, right) || IsPalindrome(s, left, right - 1);
        }
        
        left++;
        right--;
    }

    return true;
}

bool IsPalindrome(string s, int left, int right)
{
    while (left < right)
    {
        if (s[left] != s[right])
        {
            return false;
        }
        
        left++;
        right--;
    }
    
    return true;
}