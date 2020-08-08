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
        public void GivenIPLMostWicketsFile_WhenAnalysedForSorting_ThenShouldReturnBowlingAverageInAscOrder()
        {
            CricketAnalyser cricketAnalyser = new CricketAnalyser(IPL_MOST_WICKETS_FILE);
            string jsonData = cricketAnalyser.SortByBowlingAverage();
            JArray jArray = JArray.Parse(jsonData);
            string bowlingAverageFirstValue = jArray[13]["Avg"].ToString();
            Assert.AreEqual("11", bowlingAverageFirstValue);
        }

        [Test]
        public void GivenIPLMostWicketsFile_WhenAnalysedForSorting_ThenShouldReturnBowlingStrikingRateInAsccOrder()
        {
            CricketAnalyser cricketAnalyser = new CricketAnalyser(IPL_MOST_WICKETS_FILE);
            string jsonData = cricketAnalyser.SortByBowlingStrikingRate();
            JArray jArray = JArray.Parse(jsonData);
            string bowlingStrikingRateFirstValue = jArray[13]["SR"].ToString();
            Assert.AreEqual("8.66", bowlingStrikingRateFirstValue);
        }

        [Test]
        public void GivenIPLMostWicketsFile_WhenAnalysedForSorting_ThenShouldReturnBowlingEconomyInAsccOrder()
        {
            CricketAnalyser cricketAnalyser = new CricketAnalyser(IPL_MOST_WICKETS_FILE);
            string jsonData = cricketAnalyser.SortByBowlingEconomy();
            JArray jArray = JArray.Parse(jsonData);
            string bowlingStrikingRateFirstValue = jArray[0]["Econ"].ToString();
            Assert.AreEqual("4.8", bowlingStrikingRateFirstValue);
        }

        [Test]
        public void GivenIPLMostWicketsFile_WhenAnalysedForSorting_ThenShouldReturnBowlingStrikingRateInAsccOrderWithFourWAndFiveW()
        {
            CricketAnalyser cricketAnalyser = new CricketAnalyser(IPL_MOST_WICKETS_FILE);
            string jsonData = cricketAnalyser.SortByBowlingStrikingRate();
            JArray jArray = JArray.Parse(jsonData);
            string FourWFirstValue = jArray[13]["FourW"].ToString();
            string FiveWFirstValue= jArray[13]["FiveW"].ToString();
            string bowlingStrikingRateFirstValue = jArray[13]["SR"].ToString();
            Assert.AreEqual("8.66:5W=1:4W=0", bowlingStrikingRateFirstValue+":5W="+FiveWFirstValue+":4W="+FourWFirstValue);
        }

        [Test]
        public void GivenIPLMostWicketsFile_WhenAnalysedForSorting_ThenShouldReturnBowlingStrikingRateInAsccOrderWithBowlingStrikeRate()
        {
            CricketAnalyser cricketAnalyser = new CricketAnalyser(IPL_MOST_WICKETS_FILE);
            string jsonData = cricketAnalyser.SortByBowlingAverage();
            JArray jArray = JArray.Parse(jsonData);
            string bowlingAverageFirstValue = jArray[13]["Avg"].ToString();
            string bowlingStrikingRateFirstValue = jArray[13]["SR"].ToString();
            Assert.AreEqual("11:SR=12", bowlingAverageFirstValue+":SR="+ bowlingStrikingRateFirstValue);
        }

        [Test]
        public void GivenIPLMostWicketsFile_WhenAnalysedForSorting_ThenShouldReturnWicketsInDescOrderWithBowlingAverage()
        {
            CricketAnalyser cricketAnalyser = new CricketAnalyser(IPL_MOST_WICKETS_FILE);
            string jsonData = cricketAnalyser.SortByMostWickets();
            JArray jArray = JArray.Parse(jsonData);
            string wicketsFirstValue = jArray[0]["Wkts"].ToString();
            string bowlingAverageFirstValue = jArray[0]["Avg"].ToString();
            Assert.AreEqual("26:BowlingAvg=16.57", wicketsFirstValue+":BowlingAvg="+bowlingAverageFirstValue);
        }

        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnMostHundredsInDescOrderWithBattingAverage()
        {
            CricketAnalyser cricketAnalyser = new CricketAnalyser(IPL_MOST_RUNS_FILE);
            string jsonData = cricketAnalyser.SortByMostHundreds();
            JArray jArray = JArray.Parse(jsonData);
            string hundredsfirstValue = jArray[0]["Hundreds"].ToString();
            string battingAveragefirstValue = jArray[0]["Avg"].ToString();
            Assert.AreEqual("1:Avg=69.2", hundredsfirstValue+":Avg="+battingAveragefirstValue);
        }

        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnBestAverageWithZeroHundredsAndFifties()
        {
            CricketAnalyser cricketAnalyser = new CricketAnalyser(IPL_MOST_RUNS_FILE);
            string jsonData = cricketAnalyser.SortByFifties();
            JArray jArray = JArray.Parse(jsonData);
            string battingAveragefirstValue = jArray[0]["Avg"].ToString();
            Assert.AreEqual("69.2",battingAveragefirstValue);
        }
    }
}