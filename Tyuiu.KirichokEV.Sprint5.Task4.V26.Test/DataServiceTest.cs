using System.IO;

using Tyuiu.KirichokEV.Sprint5.Task4.V26.Lib;

namespace Tyuiu.KirichokEV.Sprint5.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Sveta\AppData\Local\Temp\DataSprint5\InPutDataFileTask4V26.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}