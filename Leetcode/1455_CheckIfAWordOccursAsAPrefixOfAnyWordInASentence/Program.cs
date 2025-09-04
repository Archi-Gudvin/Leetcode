string sentence = "i love eating burger";
string searchWord = "burg";

Console.WriteLine(IsPrefixOfWord(sentence, searchWord));

int IsPrefixOfWord(string sentence, string searchWord)
{
        string[] words = sentence.Split(' ').ToArray();

        for (int i = 0; i < words.Length; i++)
        {
                if (words[i].StartsWith(searchWord))
                {
                        return i + 1;
                } 
        }

        return -1;
}