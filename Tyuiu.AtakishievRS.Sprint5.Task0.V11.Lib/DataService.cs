using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AtakishievRS.Sprint5.Task0.V11.Lib
{
    public class DataService : ISprint5Task0V11
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            double z = (4 - Math.Pow((double)x, 3)) / Math.Pow((double)x, 2);
            z = Math.Round(z, 3);

            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
