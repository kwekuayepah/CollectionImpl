using System;
using System.Collections.Generic;
using TopTenPops;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();
            reader.RemoveCommaCountries(countries);
            
            Console.Write("Enter the no. of countries to display> ");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if (!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must type a positive number. Exiting...");
                return;
            }

            int maxToDisplay = userInput;


            // foreach (var country in countries)
            // {
            //     Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            // }

            for (int i = 0; i < countries.Count; i++)
            {
                if (i > 0 && (i % maxToDisplay == 0))
                {
                    Console.WriteLine("Hit return to continue, anything else to quit");
                    if(Console.ReadLine() != "")
                        break;
                }
                var country = countries[i];
                Console.WriteLine($"{i+1}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");

            }

        }
    }
}