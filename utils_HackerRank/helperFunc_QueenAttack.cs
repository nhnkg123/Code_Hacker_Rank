namespace Test.utils_HackerRank
{
    public class helperFunc_QueenAttack
    {
        public int QueenAttack(int numOfRowsColumns, int[] queenPosition, int[][] obstacles)
        {
            HashSet<string> obstacleSet = new HashSet<string>();

            foreach (int[] obstacle in obstacles)
            {
                obstacleSet.Add($"{obstacle[0]}-{obstacle[1]}");
            }

            int[][] directions = new int[][] {
                new int[2]{ -1 , 0},
                new int[2]{ 1 , 0},
                new int[2]{ 0 , -1},
                new int[2]{ 0 , 1},
                new int[2]{ -1 , -1},
                new int[2]{ 1 , -1},
                new int[2]{ 1 , 1},
                new int[2]{ -1 , 1},
            };

            int count = CountPositionResult(directions, queenPosition, numOfRowsColumns, obstacleSet);

            return count;

        }

        public static int CountPositionResult(int[][] directions, int[] queenPosition, int numOfRowsColumns, HashSet<string> obstacleSet)
        {
            int count = 0;

            foreach (int[] direction in directions)
            {
                int rowCurrent = queenPosition[0] + direction[0];
                int columnCurrent = queenPosition[1] + direction[1];

                while (rowCurrent >= 1 && rowCurrent <= numOfRowsColumns && columnCurrent >= 1 && columnCurrent <= numOfRowsColumns)
                {
                    if (obstacleSet.Contains($"{rowCurrent}-{columnCurrent}"))
                    {
                        break;
                    }

                    count++;

                    rowCurrent += direction[0];
                    columnCurrent += direction[1];
                }
            }

            return count;
        }
    }
}