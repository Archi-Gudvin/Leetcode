
var haystack = Console.ReadLine();
var needle =  Console.ReadLine();

Console.WriteLine(StrStr(haystack, needle));
//TODO
int StrStr(string haystack, string needle)
{
        int index = -1;
        var isContain = haystack.Contains(needle);
        if (isContain)
        {
            int k = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                
            }
        }
        
        return 0;
}