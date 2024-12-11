using System.IO;

using Tyuiu.KirichokEV.Sprint5.Task0.V25.Lib;

namespace Tyuiu.KirichokEV.Sprint5.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Sveta\source\repos\Tyuiu.KirichokEV.Sprint5\Tyuiu.KirichokEV.Sprint5.Task0.V25\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
