var arr1 = new int[] { 4,5,8 };
var arr2 = new int[] { 10,9,1,8 };
int d = 2;
Console.WriteLine(FindTheDistanceValue(arr1, arr2, d));

int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
{
   int value = 0;
   int temp = 0;

   int k = 0;
   for (int i = 0; i < arr1.Length; i++)
   {
      while (k < arr2.Length)
      {
         temp = Math.Abs(arr1[i] - arr2[k]);
         
         if (temp <= d)
         {
            temp = -1;
            break;
         }

         k++;
      }

      if (temp != -1)
      {
         value++;
      }

      k = 0;
   }
   
   return value;
}