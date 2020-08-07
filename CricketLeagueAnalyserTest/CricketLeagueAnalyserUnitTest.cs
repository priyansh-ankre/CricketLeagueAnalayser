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
            string playerfirstValue = jArray[0]["PLAYER"].ToString();
            string sixesfirstValue = jArray[0]["Sixs"].ToString();
            Assert.AreEqual("Andre Russell:52", playerfirstValue+":"+sixesfirstValue);
        }

        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnBatsmenStrikingRateWithSixesAndFoursInDescOrder()
        {
            CricketLeagueAnalyser.CricketAnalyser cricketAnalyser = new CricketLeagueAnalyser.CricketAnalyser(IPL_MOST_RUNS_FILE);
            string jsonData = cricketAnalyser.SortByBatsmenStrikingRate();
            JArray jArray = JArray.Parse(jsonData);
            string playerfirstValue = jArray[0]["PLAYER"].ToString();
            string sixesfirstValue = jArray[0]["Sixs"].ToString();
            string foursfirstValue = jArray[0]["Fours"].ToString();
            string firstValue = jArray[0]["SR"].ToString();
            Assert.AreEqual("Ishant Sharma:Strike Rate=333.33:Sixes=1:Fours=1", playerfirstValue+":Strike Rate="+firstValue+":Sixes="+sixesfirstValue+":Fours="+foursfirstValue);
        }


    }
}