var s = Console.ReadLine();
var k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CountKConstraintSubstrings(s, k));

int CountKConstraintSubstrings(string s, int k)
{
        int amount = s.Length + (k * (k + 1) / 2); //минимум подходящих подстрок

        int windowSize = k + 1;

        for (int i = 0; i < s.Length; i++)
        {
                if (k + 1 <= s.Length)
                {
                        string str = s.Substring(i, k + 1);

                        if (str.Count(x => x == '1') <= k || str.Count(x => x == '0') <= k)
                        {
                                amount++;
                        }   
                }
                
        }
        
        return amount;
}