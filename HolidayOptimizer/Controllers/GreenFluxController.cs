using CoreApiClient;
using HolidayOptimizer.ActionFilters;
using HolidayOptimizer.BL;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HolidayOptimizer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreenFluxController : ControllerBase
    {


        [HttpGet]
        [Route("GetCuntrywithmostholidays")]
        [Throttle(Name = "ThrottleTest", Seconds = 60)]
        public async Task<JsonResult> GetCuntrywithmostholidays()
        {
            var date = await CountrySingleton.Singleton;
            var countrycode =HolidayCalc.GetCuntrywithmostholidays(date.reuslt_holiday);


            return new JsonResult(new { countrycode });
        }
        [HttpGet]
        [Route("getmonthwithmosthoilidays")]
        [Throttle(Name = "ThrottleTest", Seconds = 60)]
        public async Task<JsonResult> getmonthwithmosthoilidays()
        {
            var date = await CountrySingleton.Singleton;
            var countrycode = HolidayCalc.getmonthwithmosthoilidays(date.reuslt_holiday);


            return new JsonResult(new { countrycode });
        }
        [HttpGet]
        [Route("getcountrywithmostuniqueholidays")]
        [Throttle(Name = "ThrottleTest", Seconds = 60)]
        public async Task<JsonResult> getcountrywithmostuniqueholidays()
        {
            var date = await CountrySingleton.Singleton;
            var countrycode = HolidayCalc.getcountrywithmostuniqueholidays(date.reuslt_holiday);


            return new JsonResult(new { countrycode });
        }
        [HttpGet]
        [Route("getLongestLastingSequencehoilidays")]
        [Throttle(Name = "ThrottleTest", Seconds = 60)]
        public async Task<JsonResult> getLongestLastingSequencehoilidays()
        {
            var date = await CountrySingleton.Singleton;
            var countrycode = HolidayCalc.getLongestLastingSequencehoilidays(date.reuslt_holiday);


            return new JsonResult(new { countrycode });
        }
    }
}