var str = Console.ReadLine();

int[] colors = str.Split(' ').Select(int.Parse).ToArray();

Console.WriteLine(NumberOfAlternatingGroups(colors));


int NumberOfAlternatingGroups(int[] colors)
{
        int windowSum = 0;
        int k = 0;

        for (int i = k; i < colors.Length - 1; i++)
        {
                //средняя плитка НЕ равна по цвету боковым
                if (colors[i - 1] != colors[i] && colors[i] != colors[i + 1])
                {
                        windowSum++;
                }
        }

        k = colors.Length - 1;

        if (colors[colors.Length - 2] != colors[k] && colors[0] != colors[k])
        {
                windowSum++;
        }

        k = 0;
        
        if (colors[colors.Length - 1] != colors[k] && colors[1] != colors[k])
        {
                windowSum++;
        }
        
        return windowSum;
}