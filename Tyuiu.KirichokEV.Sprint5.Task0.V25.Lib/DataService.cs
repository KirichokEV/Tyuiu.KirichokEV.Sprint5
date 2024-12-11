using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KirichokEV.Sprint5.Task0.V25.Lib
{
    public class DataService : ISprint5Task0V25
    {
        public string SaveToFileTextData(int x)
        {

            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
            double z = (3 * (Math.Pow((double)x, 4)) + 1) / (Math.Pow(x, 3));
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}

