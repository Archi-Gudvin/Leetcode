var nums = new[] { 3, 0, 1 };

Console.WriteLine(MissingNumber(nums));

int MissingNumber(int[] nums)
{
        int resultSum = 0;
        int realSum = 0;

        for (int i = 0; i < nums.Length + 1; i++)
        {
                if (i < nums.Length)
                {
                        realSum += nums[i];
                }
                
                resultSum += i;
        }

        return (realSum - resultSum) * -1;
}