using NUnit.Framework;
using CricketLeagueAnalyser;
using Moq;

namespace CricketLeagueAnalyserMoq
{
    public class CricketLeagueAnalyserMoqTest
    {
        
        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnBattingAverageInDescOrder()
        {
            var mockObj = new Mock<ICricketAnalyser>();
            mockObj.Setup(self => self.SortByBattingAverage()).Returns("83.2");
            Assert.AreEqual("83.2", mockObj.Object.SortByBattingAverage());
        }

        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnBatsmenStrikingRateInDescOrder()
        {
            var mockObj = new Mock<ICricketAnalyser>();
            mockObj.Setup(self => self.SortByBatsmenStrikingRate()).Returns("333.33");
            Assert.AreEqual("333.33", mockObj.Object.SortByBatsmenStrikingRate());
        }

        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnMostSixesHitInDescOrder()
        {
            var mockObj = new Mock<ICricketAnalyser>();
            mockObj.Setup(self => self.SortByMostSixesHit()).Returns("52");
            Assert.AreEqual("52", mockObj.Object.SortByMostSixesHit());
        }

        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnRunsInDescOrder()
        {
            var mockObj = new Mock<ICricketAnalyser>();
            mockObj.Setup(self => self.SortByMostRuns()).Returns("692");
            Assert.AreEqual("692", mockObj.Object.SortByMostRuns());
        }

        [Test]
        public void GivenIPLMostWicketsFile_WhenAnalysedForSorting_ThenShouldReturnBowlingAverageInAscOrder()
        {
            var mockObj = new Mock<ICricketAnalyser>();
            mockObj.Setup(self => self.SortByBowlingAverage()).Returns("11");
            Assert.AreEqual("11", mockObj.Object.SortByBowlingAverage());
        }

        [Test]
        public void GivenIPLMostWicketsFile_WhenAnalysedForSorting_ThenShouldReturnBowlingStrikingRateInAsccOrder()
        {
            var mockObj = new Mock<ICricketAnalyser>();
            mockObj.Setup(self => self.SortByBowlingStrikingRate()).Returns("8.66");
            Assert.AreEqual("8.66", mockObj.Object.SortByBowlingStrikingRate());
        }

        [Test]
        public void GivenIPLMostWicketsFile_WhenAnalysedForSorting_ThenShouldReturnBowlingEconomyInAsccOrder()
        {
            var mockObj = new Mock<ICricketAnalyser>();
            mockObj.Setup(self => self.SortByBowlingEconomy()).Returns("4.8");
            Assert.AreEqual("4.8", mockObj.Object.SortByBowlingEconomy());
        }

        [Test]
        public void GivenIPLMostWicketsFile_WhenAnalysedForSorting_ThenShouldReturnWicketsInDescOrder()
        {
            var mockObj = new Mock<ICricketAnalyser>();
            mockObj.Setup(self => self.SortByMostWickets()).Returns("26");
            Assert.AreEqual("26", mockObj.Object.SortByMostWickets());
        }
                                
        [Test]
        public void GivenIPLMostRunsFile_WhenAnalysedForSorting_ThenShouldReturnMostHundredsInDescOrderWithBattingAverage()
        {
            var mockObj = new Mock<ICricketAnalyser>();
            mockObj.Setup(self => self.SortByMostHundreds()).Returns("69.2");
            Assert.AreEqual("69.2", mockObj.Object.SortByMostHundreds());
        }
    }
}