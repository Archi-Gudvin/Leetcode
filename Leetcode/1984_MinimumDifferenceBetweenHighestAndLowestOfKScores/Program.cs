int[] nums = [9, 4, 1, 7];
int k = 2;


Console.WriteLine(MinimumDifference(nums, k));

int MinimumDifference(int[] nums, int k)
{
    if (nums.Length == 1 || k == 1)
        return 0;

    int minValue = int.MaxValue;

    Array.Sort(nums);

    int windowSize = k - 1;

    int windowValue = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (i + windowSize < nums.Length)
        {
            windowValue = nums[i + windowSize] - nums[i];

            minValue = Math.Min(minValue, windowValue);
        }
    }

    return minValue;
}