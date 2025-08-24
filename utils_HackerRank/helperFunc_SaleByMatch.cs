namespace Test.utils_HackerRank
{
    public class helperFunc_SaleByMatch
    {
        public int SaleByMatchUseLinq(int[] arr)
        {
            // return arr.GroupBy(x => x)
            //           .Select(group => group.Count() / 2)
            //           .Sum();

            return arr.GroupBy(x => x)
                      .Sum(group => group.Count() / 2);
        }

        public int SaleByMatch(int[] arr)
        {
            Dictionary<int, int> FrepDict = getFrepDict(arr);

            int sum = 0;

            foreach (var i in FrepDict)
            {
                Console.WriteLine(i.Value / 2);
                sum += i.Value / 2;
            }

            return sum;
        }

        public static Dictionary<int, int> getFrepDict(int[] arr)
        {
            Dictionary<int, int> FrepDict = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                if (FrepDict.ContainsKey(i))
                {
                    FrepDict[i]++;
                }
                else
                {
                    FrepDict[i] = 1;
                }
            }

            return FrepDict;
        }
    }
}