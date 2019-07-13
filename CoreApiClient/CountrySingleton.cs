using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreApiClient
{
    //public sealed class CountrySingleton
    //{
    //    private static CountrySingleton _instance;
    //    private CountrySingleton()
    //    {

    //    }
    //    public static CountrySingleton instance
    //    {
    //        get
    //        {
    //            if (_instance == null)
    //            {
    //                _instance = new CountrySingleton();
    //            }
    //            return _instance;
    //        }
    //    }
    //}
    public class CountrySingleton
    {
        private static readonly object SyncObj = new object();
        private static Task<CountrySingleton> _singleton;

        /// <summary>
        /// The public available singleton instance.
        /// </summary>
        public static Task<CountrySingleton> Singleton
        {
            get
            {
                if (_singleton == null)
                {
                    lock (SyncObj)
                    {
                        if (_singleton == null)
                        {
                            _singleton = CreateSingleton();
                        }
                    }
                }

                return _singleton;
            }
        }

        /// <summary>
        /// The private instance-constructor, taking some data.
        /// </summary>
        private CountrySingleton(List<TimeZoneModule> reuslt_timezone, List<Holiday> reuslt_holiday, List<Holiday> reuslt_holiday_withunionUTC)
        {
            this.reuslt_timezone = reuslt_timezone;
            this.reuslt_holiday = reuslt_holiday;
            this.reuslt_holiday_withunionUTC = reuslt_holiday_withunionUTC;
        }

        /// <summary>
        /// Some data that the singleton exposes.



        public List<TimeZoneModule> reuslt_timezone
        { get; }
        public List<Holiday> reuslt_holiday
        { get; }
        public List<Holiday> reuslt_holiday_withunionUTC
        { get; }
        /// <summary>
        /// Create the singleton instance.
        /// </summary>
        private static async Task<CountrySingleton> CreateSingleton()
        {
            var country = new Cunteries();
            var cuntrylist = country.getAllCunteries();
            List<TimeZoneModule> reuslt_timezone = new List<TimeZoneModule>();
            List<Holiday> reuslt_holiday = new List<Holiday>();
            List<Holiday> reuslt_holiday_withunionUTC = new List<Holiday>();
            foreach (var cuntrycode in cuntrylist)
            {
                ApiClient timezone = new ApiClient(new System.Uri("https://restcountries.eu/rest/v2/alpha/"));
                var timezoneResult = await timezone.GetTimeZone(cuntrycode);
                ApiClient holiday = new ApiClient(new System.Uri("https://date.nager.at/api/v2/publicholidays/"));
                List<Holiday> reuslt_holidayupdatetimezone = new List<Holiday>();

                var holidayResult = await holiday.GetHoliday("2019", cuntrycode);
                foreach (var day in holidayResult)
                {
                    foreach (var zone in timezoneResult.timezones)
                    {
                        var newholiday = day;
                        var uniondate = day.date.ToString() + " " + zone.ToString().Replace("UTC", "");
                        newholiday.date = DateTimeOffset.Parse(uniondate).UtcDateTime;
                        reuslt_holiday_withunionUTC.Add(newholiday);
                    }
                }
                reuslt_holiday.AddRange(holidayResult);
                reuslt_timezone.Add(timezoneResult);
            }
            return new CountrySingleton(reuslt_timezone, reuslt_holiday, reuslt_holiday_withunionUTC);
        }


    }
}
