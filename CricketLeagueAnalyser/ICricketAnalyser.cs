namespace CricketLeagueAnalyser
{
    public interface ICricketAnalyser
    {
        public string SortByBattingAverage();
        public string SortByBatsmenStrikingRate();
        public string SortByMostSixesHit();
        public string SortByMostRuns();
        public string SortByBowlingAverage();
        public string SortByBowlingStrikingRate();
        public string SortByBowlingEconomy();
        public string SortByMostWickets();
        public string SortByMostHundreds();
        public string SortByLeastHundreds();
        public string SortByFifties();
    }
}
