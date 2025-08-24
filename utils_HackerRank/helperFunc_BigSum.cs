namespace Test.utils_HackerRank
{
    public class helperFunc_BigSum
    {
        public string BigSum(int[] arr)
        {
            string sum = "";
            for (int i = 0; i < arr.Length; i++)
            {
                sum = Sum2String(sum, arr[i].ToString());
            }
            return sum;
        }

        public static string Sum2String(string x, string y)
        {
            string str1 = x;
            string str2 = y;

            string longerString = str1.Length > str2.Length ? str1 : str2;
            string shoterString = str1.Length < str2.Length ? str1 : str2;
            string sumResult = "";

            int diffDigit = longerString.Length - shoterString.Length;
            if (diffDigit > 0)
            {
                longerString = Add0charBefore(longerString, 1);
                shoterString = Add0charBefore(shoterString, diffDigit + 1);

                sumResult = Sum2bigNumberEqualChar(longerString, shoterString);
                if (CheckFirst0Digit(sumResult))
                {
                    return sumResult.Substring(1);
                }
                return sumResult;
            }
            longerString = Add0charBefore(str1, 1);
            shoterString = Add0charBefore(str2, 1);

            sumResult = Sum2bigNumberEqualChar(longerString, shoterString);

            if (CheckFirst0Digit(sumResult))
            {
                return sumResult.Substring(1);
            }
            return sumResult;
        }

        public static string Add0charBefore(string str, int num)
        {
            string zero = new string('0', num);
            return zero + str;
        }

        public static int Sum2Char(char char1, char char2)
        {
            return int.Parse(char1.ToString()) + int.Parse(char2.ToString());
        }

        public static string Sum2bigNumberEqualChar(string str1, string str2)
        {
            string sumResult = "";
            int remember = 0;
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                int digitResult = Sum2Char(str1[i], str2[i]) + remember;
                if (Sum2Char(str1[i], str2[i]) >= 10)
                {
                    sumResult = (digitResult - 10).ToString() + sumResult;
                    remember = 1;
                }
                else
                {
                    sumResult = digitResult.ToString() + sumResult;
                    remember = 0;
                }

            }

            return sumResult.ToString();
        }

        public static bool CheckFirst0Digit(string str)
        {
            if (str[0] == '0')
            {
                return true;
            }
            return false;
        }
    }
}