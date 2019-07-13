using Microsoft.VisualStudio.TestTools.UnitTesting;
using HolidayOptimizer.BL;
using System.Collections.Generic;
using CoreApiClient;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        //"AD","AR","AT"
        [TestMethod]
        public void GetCuntrywithmostholidays()
        {
            List<Holiday> result = new List<Holiday>();
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 1, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 2, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 3, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 4, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 5, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 7, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 8, 1, 1, 0, 0) });
            var testresult = HolidayCalc.GetCuntrywithmostholidays(result);
            Assert.AreEqual(testresult, "AD");

            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 1, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 3, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 4, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 5, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 6, 1, 1, 0, 0) });
             testresult = HolidayCalc.GetCuntrywithmostholidays(result);
            Assert.AreEqual(testresult, "AR");
        }

        [TestMethod]
        public void getmonthwithmosthoilidays()
        {
            List<Holiday> result = new List<Holiday>();
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 1, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 2, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 3, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 4, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 5, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 7, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 8, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 1, 2, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 1, 3, 1, 0, 0) });
            var testresult = HolidayCalc.getmonthwithmosthoilidays(result);
            Assert.AreEqual(testresult, "January");

            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 3, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 4, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 5, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 6, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 7, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 8, 1, 0, 0) });
            testresult = HolidayCalc.getmonthwithmosthoilidays(result);
            Assert.AreEqual(testresult, "February");
        }
        //getcountrywithmostuniqueholidays
        [TestMethod]
        public void getcountrywithmostuniqueholidays()
        {
            List<Holiday> result = new List<Holiday>();
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 1, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 2, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 3, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 7, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 1, 2, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 1, 3, 1, 0, 0) });
            var testresult = HolidayCalc.getcountrywithmostuniqueholidays(result);
            Assert.AreEqual(testresult, "AD");

            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 3, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 4, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 5, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 6, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 7, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 8, 1, 0, 0) });
            testresult = HolidayCalc.getcountrywithmostuniqueholidays(result);
            Assert.AreEqual(testresult, "AR");
        }

        //getLongestLastingSequencehoilidays

        [TestMethod]
        public void getLongestLastingSequencehoilidays()
        {
            List<Holiday> result = new List<Holiday>();
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 1, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 1, 2, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 1, 3, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 1, 4, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 1, 5, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 1, 6, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 1, 7, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 1, 8, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 1, 9, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 1, 10, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 1, 11, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 1, 12, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 1, 13, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 1, 14, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 1, 15, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 1, 16, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 1, 17, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 1, 18, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 1, 19, 1, 0, 0) });

            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 2, 1, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 2, 2, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 2, 3, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 4, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 2, 5, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 2, 6, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 2, 7, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 2, 8, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 2, 9, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 2, 10, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 2, 11, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 2, 12, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 2, 13, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 14, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 2, 15, 1, 0, 0) });
            var testresult = HolidayCalc.getLongestLastingSequencehoilidays(result);
            Assert.AreEqual(testresult, 19);

            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 2, 16, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 17, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 2, 18, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 2, 19, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 2, 20, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 2, 21, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 2, 22, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AD", date = new System.DateTime(2019, 2, 23, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AR", date = new System.DateTime(2019, 2, 24, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 2, 25, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 2, 26, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 2, 27, 1, 0, 0) });
            result.Add(new Holiday() { countryCode = "AT", date = new System.DateTime(2019, 2, 28, 1, 0, 0) });
            testresult = HolidayCalc.getLongestLastingSequencehoilidays(result);
            Assert.AreEqual(testresult, 28);
        }

    }
}
