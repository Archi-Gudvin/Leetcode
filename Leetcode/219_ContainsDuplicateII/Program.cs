var nums = new int[] { 1,2,3,1,2,3 };
int k = 2;

Console.WriteLine(ContainsNearbyDuplicate(nums, k));


bool ContainsNearbyDuplicate(int[] nums, int k)
{
        HashSet<int> window = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
                if (window.Contains(nums[i]))
                {
                        return true;
                }

                window.Add(nums[i]);

                if (window.Count > k)
                {
                        window.Remove(nums[i - k]);
                }
        }

        return false;

        // for (int i = 0; i < nums.Length; i++)
        // {
        //         int j = i + 1;
        //         
        //         while (Math.Abs(i - j) <= k && j < nums.Length)
        //         {
        //                 if (nums[i] == nums[j])
        //                 {
        //                         return true;
        //                 }
        //                 else
        //                 {
        //                         j++;
        //                 }
        //         }
        // }
        //
        // return false;
}