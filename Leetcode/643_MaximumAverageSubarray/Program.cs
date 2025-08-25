var str = Console.ReadLine();
var k = Convert.ToInt32(Console.ReadLine());

int[] nums = str.Split(' ').Select(int.Parse).ToArray();

Console.WriteLine(FindMaxAverage(nums, k));

double FindMaxAverage(int[] nums, int k)
{
     double windowSum = 0;

     for (int i = 0; i < k; i++)
     {
          windowSum += nums[i];
     }

     double avgResult = (double)windowSum / k;

     for (int i = k; i < nums.Length; i++)
     {
          windowSum += nums[i] - nums[i - k];

          avgResult = Math.Max(avgResult, windowSum / k);
     }
     
     return avgResult;
}