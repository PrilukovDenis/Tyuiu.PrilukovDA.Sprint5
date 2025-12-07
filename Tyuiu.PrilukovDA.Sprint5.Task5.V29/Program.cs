using Tyuiu.PrilukovDA.Sprint5.Task5.V29.Lib;

DataService ds = new DataService();

string path = @"C:\Users\prilu\source\repos\Tyuiu.PrilukovDA.Sprint5\Tyuiu.PrilukovDA.Sprint5.Task5.V29\bin\Debug\net8.0\DataSprint5\InPutDataFileTask5V29.txt";


double result = ds.LoadFromDataFile(path);
Console.WriteLine("Результат: " + result);