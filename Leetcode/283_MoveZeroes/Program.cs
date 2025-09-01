
var nums = new[] { 0, 1, 0, 3, 12 };

MoveZeroes(nums);

void MoveZeroes(int[] nums)
{
    var k = 0;
    for(var i = 0; i < nums.Length; i++)
    {
        if(nums[i] != 0)
        {
            (nums[k], nums[i]) = (nums[i], nums[k]);
            k++;
        }
    }
}