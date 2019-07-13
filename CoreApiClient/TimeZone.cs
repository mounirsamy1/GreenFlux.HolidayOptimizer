using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Tasks;

namespace CoreApiClient
{
    public partial class ApiClient
    {
        public async Task<TimeZoneModule> GetTimeZone(string countryCode)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                countryCode));
            return await GetAsync<TimeZoneModule>(requestUrl);
        }
        public async Task<List<Holiday>> GetHoliday(string year, string countryCode)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
               year + "/" + countryCode));
            return await GetAsync<List<Holiday>>(requestUrl);
        }
    }
}
