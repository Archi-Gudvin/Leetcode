int[] QuickSort(int[] nums)
{
    Sort(0, nums.Length - 1);

    return nums;
    
    void Sort(int low, int high)
    {
        if (high <= low)
            return;

        var j = Partition(low, high);

        Sort(low, j - 1);
        Sort(j + 1, high);
    }

    int Partition(int low, int high)
    {
        int i = low;
        int j = high + 1;

        var pivot = nums[low];

        while (true)
        {
            while (nums[++i] < pivot)
            {
                if (i == high)
                    break;
            }

            while (pivot < nums[--j])
            {
                if (j == low)
                    break;
            }

            if (i >= j)
                break;
            
            Swap(i, j);
        }
        
        Swap(low, j);

        return j;
    }

    void Swap(int i, int j)
    {
        if (i == j)
            return;
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}