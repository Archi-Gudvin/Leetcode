var str = Console.ReadLine();

Console.WriteLine(LengthOfLastWord(str));

int LengthOfLastWord(string s) {
    string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    return words[words.Length - 1].Length;
}