namespace Test.utils_HackerRank
{
    public class helperFunc_BeautifulDayAtTheMovie
    {
        public int BeautifulDayAtTheMovie(int startingDay, int endingDay, int divisor)
        {
            int count = 0;

            for (int i = startingDay; i <= endingDay; i++)
            {
                int reverseNumber = reverseNum(i);

                if (Math.Abs(i - reverseNumber) % divisor == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int reverseNum(int num)
        {
            int numResult = 0;

            while (num != 0)
            {
                int digit = num % 10;
                numResult = numResult * 10 + digit;
                num /= 10;
            }

            return numResult;
        }
    }
}