using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationAnalyzer
{
    public class PopulationService
    {
        private readonly List<PopulationRecord> _records;

        public PopulationService(List<PopulationRecord> records)
        {
            _records = records;
        }

        public long GetPopulation(string country, int year)
        {
            var record = _records.FirstOrDefault(r => r.Country.Value.Equals(country, StringComparison.OrdinalIgnoreCase)
                                                    && r.Date == year.ToString());
            return record?.GetPopulation() ?? 0;
        }

        public long GetPopulationDifference(string country, int startYear, int endYear)
        {
            long start = GetPopulation(country, startYear);
            long end = GetPopulation(country, endYear);
            return end - start;
        }

        public Dictionary<int, double> GetPercentageGrowth(string country, int endYear)
        {
            var countryRecords = _records
                .Where(r => r.Country.Value.Equals(country, StringComparison.OrdinalIgnoreCase)
                            && int.Parse(r.Date) <= endYear)
                .OrderBy(r => int.Parse(r.Date))
                .ToList();

            var growth = new Dictionary<int, double>();
            for (int i = 1; i < countryRecords.Count; i++)
            {
                long previous = countryRecords[i - 1].GetPopulation();
                long current = countryRecords[i].GetPopulation();
                if (previous != 0)
                    growth[int.Parse(countryRecords[i].Date)] = ((double)(current - previous) / previous) * 100;
            }
            return growth;
        }


        public List<string> GetAvailableCountries()
        {
            return _records.Select(r => r.Country.Value).Distinct().ToList();
        }

        public List<int> GetAvailableYears(string country)
        {
            return _records
                .Where(r => r.Country.Value.Equals(country, StringComparison.OrdinalIgnoreCase))
                .Select(r => int.Parse(r.Date))
                .OrderBy(y => y)
                .ToList();
        }
    }
}
