using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace CricketLeagueAnalyserTest
{
    public class CricketLeagueAnalyserUnitTest
    {
        private string IPL_MOST_RUNS_FILE = @"C:\Users\hp\source\repos\CricketLeagueAnalyserApp\CricketLeagueAnalyser\CsvFiles\Day12 Data_01 IPL2019FactsheetMostRuns.csv";
        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysed_ThenShouldReturnSortedBattingAverageInDescOrder()
        {
            CricketLeagueAnalyser.CricketAnalyser cricketAnalyser = new CricketLeagueAnalyser.CricketAnalyser(IPL_MOST_RUNS_FILE);
            string jsonData = cricketAnalyser.SortByBattingAverage();
            JArray jArray = JArray.Parse(jsonData);
            string firstValue = jArray[0]["Avg"].ToString();
            Assert.AreEqual("a", firstValue);
        }
    }
}