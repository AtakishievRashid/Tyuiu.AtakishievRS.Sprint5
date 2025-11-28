using Tyuiu.AtakishievRS.Sprint5.Task6.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";
        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("В строке находится " + ds.LoadFromDataFile(path) + " удвоенных букв \"с\"");
        Console.ReadKey();
    }
}