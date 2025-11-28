using Tyuiu.AtakishievRS.Sprint5.Task4.V12.Lib;
namespace Tyuiu.AtakishievRS.Sprint5.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\bogra\Desktop\ПРОГАВУЗТИУ\Tyuiu.AtakishievRS.Sprint5\Tyuiu.AtakishievRS.Sprint5.Task4.V12.Lib\bin\Debug\OutPutFileTask4.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
