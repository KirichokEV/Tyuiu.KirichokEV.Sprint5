﻿using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KirichokEV.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] == ' ') && (line[i + 1] != ' '))
                        {
                            if (line[i + 1] == 8)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }
    }
}
