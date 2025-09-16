int[] nums = [1, 3];

var result = SortArrayByParity(nums);

foreach (var x in result)
{
    Console.Write($"{x} ");
}

int[] SortArrayByParity(int[] nums)
{
    int k = nums.Length - 1;
    int i = 0;

    while(i < k)
    {
        if (nums[i] == 0)
        {
            i++;
            continue;
        }

        if (nums[i] % 2 == 0)
        {
            i++;
            continue;
        }

        if (nums[i] % 2 != 0 && nums[k] % 2 == 0)
        {
            int temp = nums[i];
            nums[i] = nums[k];
            nums[k] = temp;

            i++; k--;
            continue;
        }

        if (nums[i] % 2 != 0 && nums[k] % 2 != 0)
        {
            k--;
            continue;
        }
    }

    return nums;
}