namespace Test.utils_HackerRank
{
    public class helperFunc_ClimbLeaderboard
    {
        public int[] ClimbLeaderboard(int[] ranked, int[] player)
        {
            int[] rankOrder = getArrRankOrder(ranked);

            int[] arrResult = getRankResult(ranked, rankOrder, player);


            return arrResult;
        }

        public static int[] getArrRankOrder(int[] ranked)
        {
            int[] rankedOrder = new int[ranked.Length];
            int prevRanked = ranked[0];
            int order = 1;

            for (int i = 0; i < ranked.Length; i++)
            {
                if (ranked[i] < prevRanked)
                {
                    prevRanked = ranked[i];
                    order++;
                }

                rankedOrder[i] = order;
            }

            return rankedOrder;
        }

        public static int[] getRankResult(int[] ranked, int[] rankedOrders, int[] player)
        {
            int[] rannkedResultArr = new int[player.Length];

            for (int i = 0; i < player.Length; i++)
            {
                rannkedResultArr[i] = calRankedPlayer(ranked, rankedOrders, player[i]);
            }

            return rannkedResultArr;
        }

        public static int calRankedPlayer(int[] ranked, int[] rankedOrder, int playerScore)
        {
            int indexRank = 0;

            for (int i = 0; i < ranked.Length; i++)
            {
                if (playerScore < ranked[i])
                {
                    indexRank = i;
                }
            }

            if (playerScore < ranked[indexRank])
            {
                return rankedOrder[indexRank] + 1;
            }
            else
            {
                return rankedOrder[indexRank];
            }
        }
    }
}