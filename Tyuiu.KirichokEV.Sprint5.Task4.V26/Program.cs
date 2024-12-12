using Tyuiu.KirichokEV.Sprint5.Task4.V26.Lib;

namespace Tyuiu.KirichokEV.Sprint5.Task4.V26
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
            Console.WriteLine("* Задание #4                                                                        *");
            Console.WriteLine("* Вариант #26                                                                       *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V26.txt Создать папку в ручную        *");
            Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть вещественное значение  *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            string path = @"C:\Users\Sveta\AppData\Local\Temp\DataSprint5\InPutDataFileTask4V26.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
