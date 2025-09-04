int[] nums = new int[] { 1,2, 3,3,4,5,6 };

Console.WriteLine(FindDuplicate(nums));

int FindDuplicate(int[] nums)
{
        HashSet<int> values = new HashSet<int>();

        foreach (var item in nums)
        {
                if (values.Contains(item))
                {
                    return item;
                }

                values.Add(item);
        }
        
        return -1;
}