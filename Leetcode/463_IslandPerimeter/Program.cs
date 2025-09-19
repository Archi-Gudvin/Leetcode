int[][] grid = [[0, 1, 0, 0], [1, 1, 1, 0], [0, 1, 0, 0], [1, 1, 0, 0]];

Console.WriteLine(IslandPerimeter(grid));


int IslandPerimeter(int[][] grid)
{
    int rows = grid.Length;
    int col = grid[0].Length;

    int result = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (grid[i][j] == 1)
            {
                result += 4;

                if (i > 0 && grid[i - 1][j] == 1)
                {
                    result -= 2;
                }

                if (j > 0 && grid[i][j - 1] == 1)
                {
                    result -= 2;
                }
            }
        }
    }

     return result;
}