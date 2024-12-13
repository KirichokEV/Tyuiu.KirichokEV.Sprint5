using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KirichokEV.Sprint5.Task5.V12.Lib
{
    public class DataService : ISprint5Task5V12
    {
        public double LoadFromDataFile(string path)
        {
            
            using (StreamReader reader = new StreamReader(path))
            {
                long positiveSum = 1;
                long negativeSum = 0;

                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    if (long.TryParse(line, out long number))
                    {
                        if (number > 0)
                        {
                            positiveSum += number;
                        }
                        else if (number < 0)
                        {
                            negativeSum += number;
                        }
                    }
                }
                return positiveSum - negativeSum;
            }
        }
    }
}
