char[] letters = new[] { 'c','f','j' };
var target = 'c';

Console.WriteLine(NextGreatestLetter(letters, target));

char NextGreatestLetter(char[] letters, char target)
{
        if (target == 'a' || target == 'z')
        {
            return letters.First();
        }

        char letter = letters.FirstOrDefault(x => x >= target);

        if (letter ==  '\0')
        {
            return letters.First();
        }

        return letter;
}