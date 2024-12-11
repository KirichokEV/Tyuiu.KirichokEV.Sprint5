using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KirichokEV.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double z;
            string strZ;
            for( int x = startValue; x <= stopValue; x++)
            {
                z = Math.Round(((Math.Cos(x)) / (x - 0.4)) + Math.Sin(x) * 8 * x + 2, 2);
                strZ = Convert.ToString(z);

                if(x != stopValue)
                {
                    File.AppendAllText(path, strZ + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strZ);
                }
            }
            return path;
        }
    }
}
