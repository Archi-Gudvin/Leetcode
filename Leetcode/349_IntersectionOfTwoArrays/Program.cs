var nums1 = new[] { 4,9,5 };
var nums2 = new[] { 9,4,9,8,4};

var result = Intersection(nums1, nums2);

foreach (var item in result)
{
       Console.Write($"{item} ");
}

int[] Intersection(int[] nums1, int[] nums2)
{
       HashSet<int> result = new HashSet<int>();

       int right, left;

       left = 0;
       right = nums1.Length - 1;

       while (left < right)
       {
              int leftValue = nums1[left];
              int rightValue = nums1[right];

              if (nums2.Contains(leftValue))
              {
                     result.Add(leftValue);
              }

              if (nums2.Contains(rightValue))
              {
                     result.Add(rightValue);
              }

              left++;
              right--;
       }

       return result.ToArray();

       //nums1.Intersect(nums2).ToArray();
}