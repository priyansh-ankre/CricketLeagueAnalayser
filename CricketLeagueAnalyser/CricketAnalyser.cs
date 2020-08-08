using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CricketLeagueAnalyser
{
    public class CricketAnalyser
    {
        public readonly string path;

        public CricketAnalyser(string path)
        {
            this.path = path;
        }

        public string CsvToJSON()
        {
            var csv = new List<string[]>();
            var lines = File.ReadAllLines(path);

            foreach (string line in lines)
                csv.Add(line.Split(','));

            var properties = lines[0].Split(',');

            var listObjResult = new List<Dictionary<string, string>>();

            for (int rows = 1; rows < lines.Length; rows++)
            {
                var objResult = new Dictionary<string, string>();
                for (int columns = 0; columns < properties.Length; columns++)
                    objResult.Add(properties[columns], csv[rows][columns]);

                listObjResult.Add(objResult);
            }
            return JsonConvert.SerializeObject(listObjResult);
        }

        public string SortByBattingAverage()
        {
            var listObj = JsonConvert.DeserializeObject<List<MostRunsModel>>(CsvToJSON());
            var desclistObj = listObj.OrderByDescending(element => element.Avg);
            return JsonConvert.SerializeObject(desclistObj);
        }

        public string SortByBatsmenStrikingRate()
        {
            var listObj = JsonConvert.DeserializeObject<List<MostRunsModel>>(CsvToJSON());
            var desclistObj = listObj.OrderByDescending(element => element.SR);
            return JsonConvert.SerializeObject(desclistObj);
        }

        public string SortByMostSixesHit()
        {
            var listObj = JsonConvert.DeserializeObject<List<MostRunsModel>>(CsvToJSON());
            var desclistObj = listObj.OrderByDescending(element => element.Sixs);
            return JsonConvert.SerializeObject(desclistObj);
        }

        public string SortByMostRuns()
        {
            var listObj = JsonConvert.DeserializeObject<List<MostRunsModel>>(CsvToJSON());
            var desclistObj = listObj.OrderByDescending(element => element.Runs);
            return JsonConvert.SerializeObject(desclistObj);
        }

        public string SortByBowlingAverage()
        {
            var listObj = JsonConvert.DeserializeObject<List<MostWicketsModel>>(CsvToJSON());
            var asclistObj = listObj.OrderBy(element => element.Avg);
            return JsonConvert.SerializeObject(asclistObj);
        }

        public string SortByBowlingStrikingRate()
        {
            var listObj = JsonConvert.DeserializeObject<List<MostWicketsModel>>(CsvToJSON());
            var asclistObj = listObj.OrderBy(element => element.SR);
            return JsonConvert.SerializeObject(asclistObj);
        }
    }
}
