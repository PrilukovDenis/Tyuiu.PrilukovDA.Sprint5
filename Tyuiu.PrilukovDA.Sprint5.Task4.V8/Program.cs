using Tyuiu.PrilukovDA.Sprint5.Task4.V8.Lib;

DataService ds = new DataService();

string path = @"C:\Users\prilu\source\repos\Tyuiu.PrilukovDA.Sprint5\Tyuiu.PrilukovDA.Sprint5.Task4.V8\bin\Debug\net8.0\DataSprint5\InPutDataFileTask4V8.txt";


double result = ds.LoadFromDataFile(path);
Console.WriteLine("Результат: " + result);