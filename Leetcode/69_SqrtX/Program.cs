
int x = 67;

Console.WriteLine(MySqrt(x));

int MySqrt(int x)
{
    if (x < 2) return x;
    
    int left = 0;
    double right = x;

    var result = BinarySearch(left, right);

    return (int)result;
    
    double BinarySearch(double left, double right)
    {
        double middleValue = (left + right) / 2;

        double sqrt = middleValue * middleValue < x ? middleValue * middleValue : Math.Round(middleValue * middleValue, 3);
        
        if (sqrt == x)
        {
            return Math.Floor(middleValue);
        }
        else
        {
            if (sqrt > x)
            {
                return BinarySearch(left, middleValue);
            }
            else
            {
                return BinarySearch(middleValue, right);
            }
        }
    }
}