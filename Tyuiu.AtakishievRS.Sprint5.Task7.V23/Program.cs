using Tyuiu.AtakishievRS.Sprint5.Task7.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Атакишиев Р.С. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Добавление в решение итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Атакишиев Р. С. | РППб-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V23.txt в котором есть      *");
        Console.WriteLine("* набор символьных данных.Удалить все русские слова из файла. Полученный  *");
        Console.WriteLine("* результат сохранить в файл OutPutDataFileTask7V23.txt.                  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        string path = $@"C:\DataSprint5\InPutDataFileTask7V23.txt";
        string expectedOutputPath = $@"C:\DataSprint5\OutPutDataFileTask7V23.txt";


        Console.WriteLine("Данные находяться в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string tempFilePath = ds.LoadDataAndSave(path);

        File.Copy(tempFilePath, expectedOutputPath, true);
        File.Delete(tempFilePath); 

        Console.WriteLine("Находится в файле : ");
        Console.WriteLine(expectedOutputPath);

        Console.ReadKey();

    }
}