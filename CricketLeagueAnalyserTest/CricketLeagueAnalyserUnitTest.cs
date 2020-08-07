using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace CricketLeagueAnalyserTest
{
    public class CricketLeagueAnalyserUnitTest
    {
        private string IPL_MOST_RUNS_FILE = @"C:\Users\hp\source\repos\CricketLeagueAnalyserApp\CricketLeagueAnalyser\CsvFiles\Day12 Data_01 IPL2019FactsheetMostRuns.csv";

        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnBattingAverageInDescOrder()
        {
            CricketLeagueAnalyser.CricketAnalyser cricketAnalyser = new CricketLeagueAnalyser.CricketAnalyser(IPL_MOST_RUNS_FILE);
            string jsonData = cricketAnalyser.SortByBattingAverage();
            JArray jArray = JArray.Parse(jsonData);
            string firstValue = jArray[0]["Avg"].ToString();
            Assert.AreEqual("83.2", firstValue);
        }

        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnBatsmenStrikingRateInDescOrder()
        {
            CricketLeagueAnalyser.CricketAnalyser cricketAnalyser = new CricketLeagueAnalyser.CricketAnalyser(IPL_MOST_RUNS_FILE);
            string jsonData = cricketAnalyser.SortByBatsmenStrikingRate();
            JArray jArray = JArray.Parse(jsonData);
            string firstValue = jArray[0]["SR"].ToString();
            Assert.AreEqual("333.33", firstValue);
        }

        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnMostSixesHitInDescOrder()
        {
            CricketLeagueAnalyser.CricketAnalyser cricketAnalyser = new CricketLeagueAnalyser.CricketAnalyser(IPL_MOST_RUNS_FILE);
            string jsonData = cricketAnalyser.SortByMostSixesHit();
            JArray jArray = JArray.Parse(jsonData);
            string PlayerfirstValue = jArray[0]["PLAYER"].ToString();
            string SixesfirstValue = jArray[0]["Sixs"].ToString();
            Assert.AreEqual("Andre Russell:52", PlayerfirstValue+":"+SixesfirstValue);
        }
    }
}