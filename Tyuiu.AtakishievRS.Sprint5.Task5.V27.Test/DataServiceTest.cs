using Tyuiu.AtakishievRS.Sprint5.Task5.V27.Lib;
namespace Tyuiu.AtakishievRS.Sprint5.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\bogra\Desktop\ПРОГАВУЗТИУ\Tyuiu.AtakishievRS.Sprint5\Tyuiu.AtakishievRS.Sprint5.Task5.V27.Lib\bin\Debug\OutPutFileTask5.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
