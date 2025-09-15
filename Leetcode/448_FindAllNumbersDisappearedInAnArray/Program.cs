int[] nums = new[] { 1,1 };

var result = FindDisappearedNumbers(nums);


IList<int> FindDisappearedNumbers(int[] nums)
{
    IList<int> result = new List<int>();
    
    HashSet<int> uniqueNums = new HashSet<int>(nums);
    
    for (int i = 0; i < nums.Length; i++)
    {
        if (!uniqueNums.Contains(i + 1))
        {
            result.Add(i + 1);
        }
    }

    return result;
}