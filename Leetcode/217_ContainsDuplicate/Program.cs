int[] nums = [1, 2, 3];

Console.WriteLine(ContainsDuplicate(nums));


bool ContainsDuplicate(int[] nums)
{
    HashSet<int> result = new HashSet<int>();

    result.Add(nums[0]);

    for (int i = 1; i < nums.Length; i++)
    {
        if (result.Contains(nums[i]))
        {
            return true;
        }
    }

    return false;
}