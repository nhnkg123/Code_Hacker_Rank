namespace Test.utils_HackerRank
{
    public class helperFunc_ArrManipulation
    {
        public int ArrayManipulation(int n, int m, int[][] queries)
        {
            int max = 0;
            int sum = 0;
            int[] arrResult = new int[n + 2];

            foreach (int[] query in queries)
            {
                int a = query[0];
                int b = query[1];
                int k = query[2];


                // vi du a=1 b=3 => arr=[100, 0, 0, -100, 0, 0, ] => sau khi cong don tu dong se tuong duong voi arr=[100, 100, 100, 0, 0, 0, ]
                arrResult[a] += k;
                arrResult[b + 1] -= k;
            }

            for (int i = 0; i < n; i++)
            {
                sum += arrResult[i];
                if (sum >= max)
                {
                    max = sum;
                }
            }
            return max;
        }
    }
}