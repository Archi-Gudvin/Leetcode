int[] nums = [2, 7, 11, 15];
var target = 9;

var result = TwoSum(nums, target);

int[] TwoSum(int[] nums, int target)
{
    int[] result = new int[2];

    for (int i = 0; i < nums.Length; i++)
    {
        var diff = target - nums[i];

        if (nums.Contains(diff))
        {
            result[i] = i;
            result[i + 1] = Array.LastIndexOf(nums, diff);
            break;
        }
        else continue;
    }

    return result;
}