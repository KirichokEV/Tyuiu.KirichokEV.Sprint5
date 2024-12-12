using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
    
namespace Tyuiu.KirichokEV.Sprint5.Task3.V9.Lib
{
    public class DataService : ISprint5Task3V9
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });

            double z = (Math.Pow(x, 3)) / (Math.Pow(x, 2) - 1);
            z = Math.Round(z, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(z));
            }
            return path;
        }
    }
}
