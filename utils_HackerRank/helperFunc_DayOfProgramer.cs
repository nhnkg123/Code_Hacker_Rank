namespace Test.utils_HackerRank
{
    public class helperFunc_DayOfProgramer
    {
        public string dayOfTheProgramer(int year)
        {
            int day = 0;
            int month = 0;

            day = findDayMonthOf256thDay(IsLeapYear(year), year == 1918)[0];
            month = findDayMonthOf256thDay(IsLeapYear(year), year == 1918)[1];

            return $"{day.ToString("D2")}.{month.ToString("D2")}.{year}";

        }

        public static bool IsLeapYear(int year)
        {
            // Julian calendar
            if (year < 1918 && year % 4 == 0)
            {
                return true;
            }

            //Gregorian calendar
            if (year > 1918)
            {
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    return true;
            }

            return false;
        }

        public static int dayOfMonth(int month, bool IsLeapYear, bool is1918)
        {
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }

            if (month == 2 && IsLeapYear)
            {
                if (is1918) return 29 - 14;
                return 29;
            }
            else
            {
                if (is1918) return 28 - 14;
                return 28;
            }
        }

        public static int[] findDayMonthOf256thDay(bool IsLeapYear, bool is1918)
        {
            int sumDay = 0;
            int day = 0;
            int month = 0;

            for (int i = 1; i <= 12; i++)
            {
                if (256 - sumDay <= dayOfMonth(i, IsLeapYear, is1918))
                {
                    day = 256 - sumDay;
                    month = i;
                    break;
                }
                sumDay += dayOfMonth(i, IsLeapYear, is1918);
            }

            return new int[2] { day, month };
        }
    }
}