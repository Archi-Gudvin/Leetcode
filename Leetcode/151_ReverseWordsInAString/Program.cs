var s = Console.ReadLine();

Console.WriteLine(ReverseWords(s));


string ReverseWords(string s) {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return String.Join(' ', words);
}