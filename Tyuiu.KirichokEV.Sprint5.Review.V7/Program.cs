﻿using Tyuiu.KirichokEV.Sprint5.Review.V7.Lib;

namespace Tyuiu.KirichokEV.Sprint5.Review.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Киричoк Е. В.| РППб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                         *");
            Console.WriteLine("* Тема: Класс File                                                                  *");
            Console.WriteLine("* Задание #7                                                                        *");
            Console.WriteLine("* Вариант #7                                                                        *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("*Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл в котором есть   *");
            Console.WriteLine("* набор значений.                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V7.txt";
            string pathSaveFile = @"C:\DataSprint5\OutPutFileTask7V7.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine(pathSaveFile);
            Console.ReadKey();

        }
    }
}