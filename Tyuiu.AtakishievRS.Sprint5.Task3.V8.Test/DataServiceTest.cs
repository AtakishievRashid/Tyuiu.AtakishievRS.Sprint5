using Tyuiu.AtakishievRS.Sprint5.Task3.V8.Lib;
namespace Tyuiu.AtakishievRS.Sprint5.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\bogra\Desktop\ПРОГАВУЗТИУ\Tyuiu.AtakishievRS.Sprint5\Tyuiu.AtakishievRS.Sprint5.Task3.V8\bin\Debug\OutPutFileTask3.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
