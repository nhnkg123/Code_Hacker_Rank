namespace Test.utils_HackerRank
{
    public class helperFunc_2DArray
    {
        public int[] twoDArray(string[] stringList, string[] queries)
        {
            int[] result = new int[queries.Length];
            Dictionary<string, int> frepMap = new Dictionary<string, int>();

            foreach (string i in stringList)
            {
                if (frepMap.ContainsKey(i))
                {
                    frepMap[i]++;
                }
                else
                {
                    frepMap[i] = 1;
                }
            }

            //get queries
            for (int i = 0; i < queries.Length; i++)
            {
                if (frepMap.ContainsKey(queries[i]))
                {
                    result[i] = frepMap[queries[i]];
                }
                else
                {
                    result[i] = 0;
                }
            }
            return result;
        }
    }
}