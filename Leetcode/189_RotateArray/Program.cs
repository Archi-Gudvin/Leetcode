
var nums = new[] { 1, 2, 3, 4, 5, 6, 7 };
var k = 3;
Rotate(nums, k);

void Rotate(int[] nums, int k) {

     while (k > 0)
     {
          int tempValue = nums[0];
     
          nums[0] = nums[nums.Length - 1];
          
          for (int i = 1; i < nums.Length; i++)
          {
              int temp2 = nums[i];
              nums[i] = tempValue;
              tempValue = temp2;
          }
     
          k--;
     }
}