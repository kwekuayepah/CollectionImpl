using System;
using System.Collections.Generic;
using System.Linq;
using TopTenPops;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            Dictionary<string,List<Country>> countries = reader.ReadAllCountries();

            foreach (var region in countries.Keys)
            {
                Console.WriteLine(region);
            }
            
            Console.WriteLine("Which of the above countries do you want? ");
            string chosenRegion = Console.ReadLine();

            if (countries.ContainsKey(chosenRegion))
            {
                foreach (var country in countries[chosenRegion].Take(10))
                {
                    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
                }
            }
            else
            {
                Console.WriteLine("this is not a valid region");
            }

            // Console.Write("Enter the no. of countries to display> ");
            // bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            // if (!inputIsInt || userInput <= 0)
            // {
            //     Console.WriteLine("You must type a positive number. Exiting...");
            //     return;
            // }

            //int maxToDisplay = userInput;


            // foreach (var country in countries.Where(x=>!x.Name.Contains(',')).Take(20))
            // {
            //     Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            // }

            // for (int i = 0; i < countries.Count; i++)
            // {
            //     if (i > 0 && (i % maxToDisplay == 0))
            //     {
            //         Console.WriteLine("Hit return to continue, anything else to quit");
            //         if(Console.ReadLine() != "")
            //             break;
            //     }
            //     var country = countries[i];
            //     Console.WriteLine($"{i+1}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            //
            // }

        }
    }
}