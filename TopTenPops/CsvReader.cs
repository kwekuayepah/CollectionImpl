using System;
using System.IO;

namespace TopTenPops
{
    public class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public Country[] ReadFirstNCountry(int nCountries)
        {
            Country[] countries = new Country[nCountries];

            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                //header line
                sr.ReadLine();

                for (int q = 0; q < nCountries; q++)
                {
                    string csvLine = sr.ReadLine();
                    countries[q] = ReadCountryFromCsvLine(csvLine);
                }
            }
            return countries;
        }

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(",");
            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            string population = parts[3];
            
            return new Country(name, code, region, int.Parse(population));
        }
    }
}