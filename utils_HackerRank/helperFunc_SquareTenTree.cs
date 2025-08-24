namespace Test.utils_HackerRank
{
    public class helperFunc_SquareTenTree
    {
        public List<(int, int)> SquareTenTree(int L, int R)
        {
            long l = (long)L;
            long r = (long)R;

            List<int> levels = new List<int>();

            // wh?ile (l < r)
            // {
            for (int i = 17; i >= 0; i--)
            {
                long len = (long)Math.Pow(10, i);
                if (l % len == 0 && l + len <= r)
                {
                    l += len;
                    levels.Add(i);
                    break;
                }
            }
            // }

            // Console.WriteLine("test levels.................");
            // foreach (int item in levels)
            // {
            //     Console.Write(item + " ");
            // }
            Console.WriteLine();
            //compress the result
            List<(int count, int level)> compressList = new List<(int, int)>();
            for (int i = 0; i < levels.Count; i++)
            {
                if (compressList.Count > 0 && compressList[levels[i]].level == levels[i])
                {
                    int currentCount = compressList[levels[i]].count + 1;
                    int currentLevel = compressList[levels[i]].level;
                    compressList.Add((currentCount, currentLevel));
                }
                else
                {
                    compressList.Add((1, i));
                }
            }
            return compressList;
        }
    }
}