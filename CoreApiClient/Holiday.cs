using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApiClient
{
    public class Holiday
    {
        public string month { get => date.ToString("MMMM"); }

        public DateTime date { get; set; }
        public string localName { get; set; }
        public string name { get; set; }
        public string countryCode { get; set; }
        public bool Fixed { get; set; }
        public bool global { get; set; }
        //public string counties { get; set; }
        public int? launchYear { get; set; }
        public string type { get; set; }
    }
}
