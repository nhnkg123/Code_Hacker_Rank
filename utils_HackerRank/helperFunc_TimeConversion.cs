using System.Globalization;
using System.Runtime.CompilerServices;
using Test.Constants;

namespace Test.utils_HackerRank
{
    public class helperFunc_TimeConversion
    {
        public string TimeConversion(string prevTime)
        {
            if (!checkValidDate(prevTime))
            {
                Console.WriteLine("please input a correct format");
                return "";
            }

            string[] timeArr = prevTime.Split(":");
            string hour = timeArr[0];
            string minute = timeArr[1];
            string second = splitSecondAMPM(timeArr[2])[0];
            string AMPM = splitSecondAMPM(timeArr[2])[1];

            if (AMPM == Commons.PM)
            {
                hour = (int.Parse(hour.ToString()) + 12).ToString();
                string formatedHour = formatHour(hour);

                return formatedHour + ":" + minute + ":" + second;
            }

            return hour + ":" + minute + ":" + second;
        }

        public static bool checkValidDate(string time)
        {
            try
            {
                DateTime date = DateTime.ParseExact(time, "hh:mm:sstt", CultureInfo.InvariantCulture);

                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }

        public static string[] splitSecondAMPM(string arr)
        {
            string[] result = new string[2];
            foreach (char i in arr)
            {
                if (int.TryParse(i.ToString(), out int x))
                {
                    result[0] += i.ToString();
                }
                else
                {
                    result[1] += i.ToString();
                }
            }
            return result;
        }

        public static string formatHour(string hour)
        {
            if (hour == "24")
            {
                return "00";
            }
            if (hour == "12")
            {
                return "12";
            }
            return hour;
        }

        public string SimplyParseExact(string time)
        {
            DateTime dateTime = DateTime.ParseExact(time, "hh:mm:sstt", CultureInfo.InvariantCulture);
            return dateTime.ToString("HH:mm:ss");
        }
    }
}