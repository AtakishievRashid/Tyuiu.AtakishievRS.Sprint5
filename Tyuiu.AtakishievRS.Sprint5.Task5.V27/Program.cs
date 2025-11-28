using Tyuiu.AtakishievRS.Sprint5.Task5.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string path = $@"C:\DataSprint5\InPutDataFileTask5V27.txt";

        double res = ds.LoadFromDataFile(path);

        Console.WriteLine("Среднее значение целых чисел, которые делятся на 5 = " + res);
        Console.ReadKey();
    }
}