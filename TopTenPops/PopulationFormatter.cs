using System;

namespace TopTenPops
{
    public class PopulationFormatter
    {
        public static string FormatPopulation(int population)
        {
            if (population == 0)
            {
                return "(Unknown)";
            }

            int popRounded = RoundPopulation4(population);

            return $"{popRounded:### ### ### ###}".Trim();
        }

        private static int RoundPopulation4(int population)
        {
            int accuracy = Math.Max((int) (GetHighestPowerOfTen(population) / 10_000l), 1);

            return RoundToNearest(population, accuracy);
        }

        private static int RoundToNearest(int exact,  int accuracy)
        {
            int adjusted = exact + accuracy / 2;
            return adjusted - adjusted % accuracy;

        }

        private static long GetHighestPowerOfTen( int x)
        {
            long result = 1;
            while (x > 0)
            {
                x /= 10;
                result *= 10;
            }
            return result;
        }
    }
}