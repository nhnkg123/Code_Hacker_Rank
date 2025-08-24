namespace Test.utils_HackerRank
{
    public class helperFunc_between2Set
    {
        //------------Cach toi uu hieu suat hon-----------------
        public int betweenTwoSet(int[] arr1, int[] arr2)
        {
            int lcm = arr1.Aggregate(LCM_LeastCommonMultiple_BCNN);
            int gcd = arr2.Aggregate(GCD_GreatestCommonDivisor_UCLN);

            int count = 0;
            for (int i = lcm; i <= gcd; i += lcm)
            {
                if (gcd % i == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int GCD_GreatestCommonDivisor_UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int LCM_LeastCommonMultiple_BCNN(int a, int b)
        {
            return (a * b) / GCD_GreatestCommonDivisor_UCLN(a, b);
        }

        // Tu lam => khong toi uu hieu suat neu mang lon -----------------------------------
        public void betweenTwoSet2(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();

            int min = arr1[arr1.Length - 1];
            int max = arr2[0];

            for (int i = min; i <= max; i++)
            {
                if (coLaBoiCuaMang(arr1, i) && coLaUocCuaMang(arr2, i))
                {
                    result.Add(i);
                }
            }

            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
        }

        public static bool coLaBoiCuaMang(int[] arr, int num)
        {
            return arr.All(x => num % x == 0);
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     if (x % arr[i] != 0)
            //     {
            //         return false;
            //     }
            // }

            // return true;
        }

        public static bool coLaUocCuaMang(int[] arr, int num)
        {
            return arr.All(x => x % num == 0);
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     if (arr[i] % x != 0)
            //     {
            //         return false;
            //     }
            // }

            // return true;
        }
    }
}