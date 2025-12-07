using Tyuiu.PrilukovDA.Sprint5.Task1.V30.Lib;

DataService ds = new DataService();
string res = ds.SaveToFileTextData(-5, 5);

Console.WriteLine("Файл создан: " + res);

Console.WriteLine("Содержимое: " + File.ReadAllText(res));