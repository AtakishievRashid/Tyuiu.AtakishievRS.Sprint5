using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AtakishievRS.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' '); 
                    foreach (string num in numbers)
                    {
                        if (Convert.ToDouble(num, CultureInfo.InvariantCulture) % 5 == 0)
                        {
                            count++;
                            res += Convert.ToDouble(num, CultureInfo.InvariantCulture);
                        }
                    }
                }
            }
            if (count > 0)
            {
                return Math.Round(res / count, 3);
            }
            else
            {
                return 0;
            }
        }
    }
}
