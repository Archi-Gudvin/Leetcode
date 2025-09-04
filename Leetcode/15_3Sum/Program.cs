﻿
int[] nums = new[] { 0,0,0 };

var res = ThreeSum(nums);

IList<IList<int>> ThreeSum(int[] nums)
{
       Array.Sort(nums);
       IList<IList<int>> result = new List<IList<int>>();
       
       for (int i = 0; i < nums.Length; i++)
       {
              if (i > 0 && nums[i] == nums[i - 1])
              {
                   continue;  
              }
              
              int j = i + 1;
              int k = nums.Length - 1;

              while (j < k)
              {
                     int sum = nums[i] + nums[j] + nums[k];

                     if (sum == 0)
                     {
                            result.Add(new int[] {nums[i], nums[j], nums[k]});
                            j++;
                            k--;

                            while (j < k && nums[j] == nums[j - 1])
                            {
                                   j++;
                            }
                            
                            while (j < k && nums[k] == nums[k + 1])
                            {
                                   k--;
                            }
                     }
                     else if(sum < 0)
                     {
                            j++;
                     }
                     else
                     {
                            k--;
                     } 
              }
       }
       
       return result;
}