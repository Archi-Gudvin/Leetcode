var nums = new int[] { -1,0,3,5,9,12 };
var target = 9;

Console.WriteLine(Search(nums, target));

int Search(int[] nums, int target) {

    int left, right, serchValue;

    left = 0;
    right = nums.Length - 1;
    serchValue = target;

    int result = BinarySearch(left, right, serchValue);
    
    int BinarySearch(int left, int right, int serchValue)
    {
        while (left <= right)
        {
            if (left > right)
            {
                return -1;
            }

            int middleIndex = (left + right) / 2;

            int middleValue = nums[middleIndex];

            if (middleValue == serchValue)
            {
                return middleIndex;
            }
            else
            {
                if (middleValue > serchValue)
                {
                    return BinarySearch(left, middleIndex - 1, serchValue);
                }
                else
                {
                    return BinarySearch(middleIndex + 1, right, serchValue);
                }
            }
        }
        
        return -1;
    }

    return result;
}