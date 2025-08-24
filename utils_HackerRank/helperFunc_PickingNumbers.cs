namespace Test.utils_HackerRank
{
    public class helperFunc_PickingNumbers
    {
        public int PickingNumber(int[] arr)
        {
            Array.Sort(arr);

            int maxLengthArr = 0;
            int count = 1;

            int baseNumber = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] - baseNumber > 1)
                {
                    baseNumber = arr[i];
                    count = 1;
                }

                if (count > maxLengthArr)
                {
                    maxLengthArr = count;
                }

                count++;
            }

            return maxLengthArr;
        }
    }
}