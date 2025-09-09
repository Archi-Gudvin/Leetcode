string s = "anagram", t = "nagaram";
Console.WriteLine(IsAnagram(s, t));


bool IsAnagram(string s, string t)
{
        if (s.Length != t.Length)
        {
            return false;
        }

        var sArr = s.ToCharArray();
        
        Array.Sort(sArr);
        
        var tArr = t.ToCharArray();
        
        Array.Sort(tArr);
        return sArr.SequenceEqual(tArr);
}