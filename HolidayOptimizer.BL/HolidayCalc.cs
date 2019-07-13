using CoreApiClient;
using System.Collections.Generic;
using System.Linq;

namespace HolidayOptimizer.BL
{
    public class HolidayCalc
    {

        public static string GetCuntrywithmostholidays(List<Holiday> reuslt_holiday)
        {
            var countryCode = reuslt_holiday.GroupBy(p => p.countryCode)
                 .Select(p => new
                 {
                     countryCode = p.Key,
                     count = p.Count()
                 })
                 .OrderByDescending(p => p.count)
                 .FirstOrDefault().countryCode;

            return countryCode;
        }

        public static string getmonthwithmosthoilidays(List<Holiday> reuslt_holiday)
        {
            var monthname = reuslt_holiday.GroupBy(p => p.month)
               .Select(p => new
               {
                   monthname = p.Key,
                   count = p.Count()
               })
               .OrderByDescending(p => p.count)
               .FirstOrDefault().monthname;
            return monthname;
        }
        public static string getcountrywithmostuniqueholidays(List<Holiday> reuslt_holiday)
        {
            var uniquedates = reuslt_holiday.GroupBy(p => p.date)
               .Select(p => new
               {
                   monthname = p.Key,
                   count = p.Count()
               })
               .Where(p => p.count == 1).Select(p => p.monthname);
            List<string> countries = new List<string>();
            foreach (var date in uniquedates)
            {
                countries.Add(reuslt_holiday.FirstOrDefault(p => p.date == date).countryCode);
            }
            var countrycode = countries.GroupBy(p => p).Select(p => new { countrycode = p, count = p.Count() })
               .OrderByDescending(p => p.count)
               .FirstOrDefault().countrycode.FirstOrDefault();

            return countrycode;
        }
        public static int getLongestLastingSequencehoilidays(List<Holiday> reuslt_holiday)
        {
            var arr = reuslt_holiday.OrderBy(p => p.date).ToArray();
            // we want to find the
            int longestConsequtiveStreak = 0; // and also
            int startIndexOfLongestStreak = 0;
            int endIndexOfLongestStreak = 0;

            // let's loop through the array to find the longest streak
            for (int i = 0; i < arr.Length - 2; i++)
            {
                // reset current variables
                int currrentStartIndex = i;
                int currentStreak = 1;

                while (theNextNumberIsConsequtive(arr, i))
                {
                    i++;
                    // currentStreak++; // add to the streak
                    currentStreak = arr[i].date.Subtract(arr[currrentStartIndex].date).Days + 1;
                }

                if (WeHaveALongerStreak(longestConsequtiveStreak, currentStreak))
                {

                    ResetAllVariables(ref longestConsequtiveStreak, ref startIndexOfLongestStreak, ref endIndexOfLongestStreak, i, currrentStartIndex, ref currentStreak);
                }
            }

            return longestConsequtiveStreak;
        }

        private static bool theNextNumberIsConsequtive(Holiday[] arr, int i)
        {
            return i < arr.Length - 1 && IsTheNextNumberConsequtive(arr, i);
        }


        private static void ResetAllVariables(ref int longestConsequtiveStreak, ref int startIndexOfLongestStreak, ref int endIndexOfLongestStreak, int i, int currrentStartIndex, ref int currentStreak)
        {
            longestConsequtiveStreak = currentStreak;
            startIndexOfLongestStreak = currrentStartIndex;
            endIndexOfLongestStreak = i;
            currentStreak = 1;
        }

        private static bool WeHaveALongerStreak(int longestConsequtiveStreak, int currentStreak)
        {
            return longestConsequtiveStreak < currentStreak;
        }

        private static bool IsTheNextNumberConsequtive(Holiday[] arr, int i)
        {
            double Milliseconds = arr[i + 1].date.Subtract(arr[i].date).TotalMilliseconds;
            if (Milliseconds <= 86400000)
            {

            }
            else
            {
            }
            return Milliseconds <= 86400000;
        }
    }
}
