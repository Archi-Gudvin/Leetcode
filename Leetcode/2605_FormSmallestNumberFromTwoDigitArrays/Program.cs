int[] nums1 = [4, 1, 3], nums2 = [1, 5, 7];

Console.WriteLine(MinNumber(nums1, nums2));


int MinNumber(int[] nums1, int[] nums2)
{
    var arrIntersect = nums1.Intersect(nums2);

    if (!arrIntersect.Any())
    {
        if (nums1.Min() < nums2.Min())
        {
            return nums1.Min() * 10 + nums2.Min();
        }
        else
        {
            return nums2.Min() * 10 + nums1.Min();
        }

        
    }
   
    return arrIntersect.Min();
}