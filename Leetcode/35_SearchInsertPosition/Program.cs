var nums = new int[] { 1, 3, 5, 6 };
var target = 7;

Console.WriteLine(SearchInsert(nums, target));

int SearchInsert(int[] nums, int target)
{
        int index = BinarySearch(0, nums.Length - 1, target);

        return index;

        int BinarySearch(int firstIndex, int lastIndex, int selectedValue)
        {
            if (firstIndex > lastIndex)
            {
                return firstIndex;
            }
            
            int middleIndex = (firstIndex + lastIndex) / 2;

            int middleValue = nums[middleIndex];

            if (middleValue == selectedValue)
            {
                return middleIndex;
            }
            else
            {
                if (middleValue > target)
                {
                    return BinarySearch(firstIndex, middleIndex - 1, selectedValue);
                }
                else if (middleValue < target)
                {
                    return BinarySearch(middleIndex + 1, lastIndex, selectedValue);
                }
            }

            return -1;
        }
}