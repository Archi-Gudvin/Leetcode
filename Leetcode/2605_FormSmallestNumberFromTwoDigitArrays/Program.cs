int[] nums1 = [4, 1, 3], nums2 = [1, 5, 7];

Console.WriteLine(MinNumber(nums1, nums2));


int MinNumber(int[] nums1, int[] nums2)
{
    var arrIntersect = nums1.Intersect(nums2);

    string result = "";

    if (!arrIntersect.Any())
    {
        int firstMinValue = nums1.Min();

        int secondMinValue = nums2.Min();

        result = $"{firstMinValue}{secondMinValue}";
    }
    else
    {
        return arrIntersect.Min();
    }

    return Convert.ToInt32(result);
}