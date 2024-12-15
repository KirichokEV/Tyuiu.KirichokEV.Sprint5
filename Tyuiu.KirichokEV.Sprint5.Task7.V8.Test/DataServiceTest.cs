using System.IO;

using Tyuiu.KirichokEV.Sprint5.Task7.V8.Lib;

namespace Tyuiu.KirichokEV.Sprint5.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Sveta\AppData\Local\Temp\DataSprint5\OutPutDataFileTask7V8.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}