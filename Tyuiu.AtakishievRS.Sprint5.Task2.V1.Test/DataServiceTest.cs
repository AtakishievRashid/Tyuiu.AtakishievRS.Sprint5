using Tyuiu.AtakishievRS.Sprint5.Task2.V1.Lib;
namespace Tyuiu.AtakishievRS.Sprint5.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\bogra\Desktop\ПРОГАВУЗТИУ\Tyuiu.AtakishievRS.Sprint5\Tyuiu.AtakishievRS.Sprint5.Task2.V1\bin\Debug\OutPutFileTask2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
