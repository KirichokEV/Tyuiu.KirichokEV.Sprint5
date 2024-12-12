using Tyuiu.KirichokEV.Sprint5.Task3.V9.Lib;

namespace Tyuiu.KirichokEV.Sprint5.Task3.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 3;
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Киричoк Е. В.| РППб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                         *");
            Console.WriteLine("* Тема: Класс File                                                                  *");
            Console.WriteLine("* Задание #3                                                                        *");
            Console.WriteLine("* Вариант #9                                                                        *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в бинарный   *");
            Console.WriteLine("* файл OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков.          *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
