var nums1 = new[] { 1,2,2,1 };
var nums2 = new[] { 2,2};

var result = Intersect(nums1, nums2);

foreach (var item in result)
{
    Console.Write($"{item} ");
}

int[] Intersect(int[] nums1, int[] nums2)
{
    return nums1.Intersect(nums2).ToArray();
}