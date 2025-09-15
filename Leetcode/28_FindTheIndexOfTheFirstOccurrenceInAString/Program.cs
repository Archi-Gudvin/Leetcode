
var haystack = "leetcode";
var needle =  "de";

Console.WriteLine(StrStr(haystack, needle));
int StrStr(string haystack, string needle)
{
        if (haystack.Contains(needle))
        {
                for (int i = 0; i < haystack.Length; i++)
                {
                        string temp = haystack.Substring(i, needle.Length);
                        
                        if (needle == temp)
                        {
                                return i;
                        }
                }
        }
        
        return -1;
}