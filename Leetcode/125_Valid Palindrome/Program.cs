string s = "A man, a plan, a canal: Panama";


Console.WriteLine(IsPalindrome(s));

bool IsPalindrome(string s)
{
    string str = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();

    string reverseSrt = new string(str.Reverse().ToArray());

    return str == reverseSrt;
}