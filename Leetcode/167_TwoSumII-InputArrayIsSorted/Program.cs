var nums = new int[] { -1,0 };
var target = -1;

TwoSum(nums, target);

int[] TwoSum(int[] numbers, int target)
{
        int[] result = new int[2];

        int left, right, sum;

        left = 0;
        right = numbers.Length - 1;

        while (left < right)
        {
            sum = numbers[left] + numbers[right];

            if (sum == target)
            {
                result[0] = left + 1;
                result[1] = right + 1;
                
                return result;
            }
            else if (sum > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return result;
}