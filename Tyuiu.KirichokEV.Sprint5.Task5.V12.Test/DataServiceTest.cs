using System.IO;

using Tyuiu.KirichokEV.Sprint5.Task5.V12.Lib;

namespace Tyuiu.KirichokEV.Sprint5.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Sveta\AppData\Local\Temp\DataSprint5\InPutDataFileTask5V12.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}