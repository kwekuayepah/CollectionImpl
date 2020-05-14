using System;
using System.Collections.Generic;
using TopTenPops;

namespace DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string filePath = "Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);
            var countries = reader.ReadAllCountries();

            Console.WriteLine("Which country code do you want to look up");
            var userInput = Console.ReadLine();

            bool gotCountry = countries.TryGetValue(userInput, out Country country);
            if (!gotCountry)
            {
                Console.WriteLine($"Sorry, there is no country with the code, {userInput}");
            }
            else
            {
                Console.WriteLine($"{country.Name} has a population {PopulationFormatter.FormatPopulation(country.Population)}");
            }
        }
    }
}