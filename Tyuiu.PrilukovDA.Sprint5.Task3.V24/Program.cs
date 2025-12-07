using Tyuiu.PrilukovDA.Sprint5.Task3.V24.Lib;

DataService ds = new DataService();
string res = ds.SaveToFileTextData(3);

Console.WriteLine("Файл создан: " + res);

using (BinaryReader reader = new BinaryReader(File.Open(res, FileMode.Open)))
{
    double value = reader.ReadDouble();
    Console.WriteLine("Значение из файла: " + value);
}

byte[] fileBytes = File.ReadAllBytes(res);
string base64 = Convert.ToBase64String(fileBytes);
Console.WriteLine("Base64 содержимого: " + base64);