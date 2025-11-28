using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.AtakishievRS.Sprint5.Task4.V12.Lib
{
    public class DataService : ISprint5Task4V12
    {
        public double LoadFromDataFile(string path)
        {
            double x = Convert.ToDouble(File.ReadAllText(path).Replace('.', ','));
            double y = Math.Cos(Math.Pow(x, 3)) + x / 2;
            return Math.Round(y, 3);
        }
    }
}
