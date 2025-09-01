int num = 9;

Console.WriteLine(IsPerfectSquare(num));

bool IsPerfectSquare(int num) {
    int left = 1, right = num/2;
    return Binarysearch(left, right, num);
}

static bool Binarysearch(int f, int l, int num)
{
    if (num==0 || num==1)
        return true;
    if (f <= l){
        int mid = (f+l)/2;
        long sq = (long)mid*mid;
        if (sq == num)
        {
            return true;
        }
        else if (sq < num)
        {
            return Binarysearch(mid+1, l, num);
        }
        else if(sq > num)
        {
            return Binarysearch(f, mid-1, num);
        }
    }
    return false;
}