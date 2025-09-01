
var s = Console.ReadLine();

Console.WriteLine(ReverseWords(s));

string ReverseWords(string s)
{
        var arr = s.Split(' ');

        for (int i = 0; i < arr.Length; i++)
        {
                var word = arr[i].ToCharArray();
                
                Array.Reverse(word);

                arr[i] = new string(word);
        }

        return String.Join(' ', arr);
}