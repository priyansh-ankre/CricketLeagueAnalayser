using Newtonsoft.Json.Linq;
using NUnit.Framework;
using CricketLeagueAnalyser;

namespace CricketLeagueAnalyserTest
{
    public class CricketLeagueAnalyserUnitTest
    {
        private string IPL_MOST_RUNS_FILE = @"C:\Users\hp\source\repos\CricketLeagueAnalyserApp\CricketLeagueAnalyser\CsvFiles\Day12 Data_01 IPL2019FactsheetMostRuns.csv";
        private string IPL_MOST_WICKETS_FILE = @"C:\Users\hp\source\repos\CricketLeagueAnalyserApp\CricketLeagueAnalyser\CsvFiles\Day12 Data_02 IPL2019FactsheetMostWkts.csv";
        
        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnBattingAverageInDescOrder()
        {
            CricketAnalyser cricketAnalyser = new CricketAnalyser(IPL_MOST_RUNS_FILE);
            string jsonData = cricketAnalyser.SortByBattingAverage();
            JArray jArray = JArray.Parse(jsonData);
            string firstValue = jArray[0]["Avg"].ToString();
            Assert.AreEqual("83.2", firstValue);
        }

        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnBatsmenStrikingRateInDescOrder()
        {
            CricketAnalyser cricketAnalyser = new CricketAnalyser(IPL_MOST_RUNS_FILE);
            string jsonData = cricketAnalyser.SortByBatsmenStrikingRate();
            JArray jArray = JArray.Parse(jsonData);
            string firstValue = jArray[0]["SR"].ToString();
            Assert.AreEqual("333.33", firstValue);
        }

        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnMostSixesHitInDescOrder()
        {
            CricketAnalyser cricketAnalyser = new CricketAnalyser(IPL_MOST_RUNS_FILE);
            string jsonData = cricketAnalyser.SortByMostSixesHit();
            JArray jArray = JArray.Parse(jsonData);
            string playerfirstValue = jArray[0]["PLAYER"].ToString();
            string sixesfirstValue = jArray[0]["Sixs"].ToString();
            Assert.AreEqual("Andre Russell:52", playerfirstValue+":"+sixesfirstValue);
        }

        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnBatsmenStrikingRateWithSixesAndFoursInDescOrder()
        {
            CricketAnalyser cricketAnalyser = new CricketAnalyser(IPL_MOST_RUNS_FILE);
            string jsonData = cricketAnalyser.SortByBatsmenStrikingRate();
            JArray jArray = JArray.Parse(jsonData);
            string playerfirstValue = jArray[0]["PLAYER"].ToString();
            string sixesfirstValue = jArray[0]["Sixs"].ToString();
            string foursfirstValue = jArray[0]["Fours"].ToString();
            string firstValue = jArray[0]["SR"].ToString();
            Assert.AreEqual("Ishant Sharma:Strike Rate=333.33:Sixes=1:Fours=1", playerfirstValue+":Strike Rate="+firstValue+":Sixes="+sixesfirstValue+":Fours="+foursfirstValue);
        }

        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnAverageInDescOrderWithNameAndStrikeRate()
        {
            CricketAnalyser cricketAnalyser = new CricketAnalyser(IPL_MOST_RUNS_FILE);
            string jsonData = cricketAnalyser.SortByBattingAverage();
            JArray jArray = JArray.Parse(jsonData);
            string playerfirstValue = jArray[0]["PLAYER"].ToString();
            string strikeRateFirstValue = jArray[0]["SR"].ToString();
            string averageFirstValue = jArray[0]["Avg"].ToString();
            Assert.AreEqual("MS Dhoni:Avg=83.2:SR=134.62", playerfirstValue+":Avg="+averageFirstValue+":SR="+strikeRateFirstValue);
        }

        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnRunsInDescOrderWithNameAndAverage()
        {
            CricketAnalyser cricketAnalyser = new CricketAnalyser(IPL_MOST_RUNS_FILE);
            string jsonData = cricketAnalyser.SortByMostRuns();
            JArray jArray = JArray.Parse(jsonData);
            string playerfirstValue = jArray[0]["PLAYER"].ToString();
            string averageFirstValue = jArray[0]["Avg"].ToString();
            string runsFirstValue = jArray[0]["Runs"].ToString();
            Assert.AreEqual("David Warner :Runs=692:Avg=69.2", playerfirstValue +":Runs="+runsFirstValue + ":Avg=" + averageFirstValue);
        }

        [Test]
        public void GivenIPLMostWicketsFile_WhenAnalysedForSorting_ThenShouldReturnBowlingAverageInDescOrder()
        {
            CricketAnalyser cricketAnalyser = new CricketAnalyser(IPL_MOST_WICKETS_FILE);
            string jsonData = cricketAnalyser.SortByBowlingAverage();
            JArray jArray = JArray.Parse(jsonData);
            string bowlingAverageFirstValue = jArray[13]["Avg"].ToString();
            Assert.AreEqual("11", bowlingAverageFirstValue);
        }
    }
}