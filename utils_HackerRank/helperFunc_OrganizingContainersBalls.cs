namespace Test.utils_HackerRank
{
    public class helperFunc_OrganizingContainersBalls
    {
        public class TestCase
        {
            public int _numContainersAndType;
            public int[,]? _matrix;

            public TestCase(int numContainersAndType, List<int> rows)
            {
                _matrix = new int[numContainersAndType, numContainersAndType];

                for (int i = 0; i < numContainersAndType; i++)
                {
                    List<int> row = getRow(numContainersAndType, i, rows);

                    for (int j = 0; j < numContainersAndType; j++)
                    {
                        _matrix[i, j] = row[j];
                    }
                }

                _numContainersAndType = numContainersAndType;
            }
        }

        public static List<int> getRow(int m, int rowIndex, List<int> rows)
        {
            int step = 0;
            int index = 0;

            for (int i = 0; i < rows.Count; i += m)
            {
                if (step == rowIndex)
                {
                    index = i;
                }
                step++;
            }

            return rows.GetRange(index, m);
        }

        public List<string> OganzingContainersBalls(int numContainersAndType, List<TestCase> allTestCase)
        {
            List<string> result = new List<string>();

            foreach (TestCase testcase in allTestCase)
            {
                string testcaseResult = handleOneTestCase(testcase);
                result.Add(testcaseResult);
            }

            return result;
        }

        public static string handleOneTestCase(TestCase testCase)
        {
            int numContainersAndType = testCase._numContainersAndType;
            int[,]? maxtrix = testCase._matrix;

            int[] arrTotalnumEachContainer = calSumRow(maxtrix, numContainersAndType);
            int[] arrTotalnumEachType = calSumColumn(maxtrix, numContainersAndType);

            Array.Sort(arrTotalnumEachContainer);
            Array.Sort(arrTotalnumEachType);

            bool is2ArrMatch = Compare2Array(arrTotalnumEachContainer, arrTotalnumEachType);

            return is2ArrMatch ? "Possible" : "Impossible";
        }

        public static int[] calSumRow(int[,] maxtrix, int numContainersAndType)
        {
            int[] result = new int[numContainersAndType];

            for (int i = 0; i < numContainersAndType; i++)
            {
                int sumRow = 0;
                for (int j = 0; j < numContainersAndType; j++)
                {
                    sumRow += maxtrix[i, j];
                }

                result[i] = sumRow;
            }

            return result;
        }

        public static int[] calSumColumn(int[,] maxtrix, int numContainersAndType)
        {
            int[] result = new int[numContainersAndType];

            for (int j = 0; j < numContainersAndType; j++)
            {
                int sumcolumn = 0;
                for (int i = 0; i < numContainersAndType; i++)
                {
                    sumcolumn += maxtrix[i, j];
                }

                result[j] = sumcolumn;
            }

            return result;
        }

        public static bool Compare2Array(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }
    }
}