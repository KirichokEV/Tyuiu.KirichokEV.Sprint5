using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KirichokEV.Sprint5.Review.V7.Lib
{
    public class DataService : ISprint5Task7V7
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask7V7.txt" });

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string STR = "";
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {

                        if ((line[i] != 'А') && (line[i] != 'Б') && (line[i] != 'В') && (line[i] != 'Г') && (line[i] != 'Д') && (line[i] != 'Е') && (line[i] != 'Ё') && (line[i] != 'Ж') && (line[i] != 'З') && (line[i] != 'И') && (line[i] != 'Й') && (line[i] != 'К') && (line[i] != 'Л') && (line[i] != 'М') && (line[i] != 'Н') && (line[i] != 'О') && (line[i] != 'П') && (line[i] != 'Р') && (line[i] != 'С') && (line[i] != 'Т') && (line[i] != 'У') && (line[i] != 'Ф') && (line[i] != 'Х') && (line[i] != 'Ц') && (line[i] != 'Ч') && (line[i] != 'Ш') && (line[i] != 'Щ') && (line[i] != 'Ъ') && (line[i] != 'Ы') && (line[i] != 'Ь') && (line[i] != 'Э') && (line[i] != 'Ю') && (line[i] != 'Я'))
                        {
                            strLine = strLine + line[i];

                        }
                        else
                        {
                            STR += line[i];
                            STR = STR.ToLower();
                            strLine = strLine + STR;
                            STR = "";
                        }

                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;

        }
    }
}
