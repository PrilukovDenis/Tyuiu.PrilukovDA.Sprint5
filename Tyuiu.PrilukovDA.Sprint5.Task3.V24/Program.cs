using Tyuiu.PrilukovDA.Sprint5.Task3.V24.Lib;

DataService ds = new DataService();

string res = ds.SaveToFileTextData(3);

Console.WriteLine("Файл создан: " + res);

Console.WriteLine("Содержимое: " + File.ReadAllText(res));