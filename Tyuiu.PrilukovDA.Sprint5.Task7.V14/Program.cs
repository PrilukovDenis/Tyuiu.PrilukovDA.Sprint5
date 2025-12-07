using Tyuiu.PrilukovDA.Sprint5.Task7.V14.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнил: Прилуков Д.А. | НТм-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #14                                                              *");
Console.WriteLine("* Выполнил: Прилуков Денис Алексеевич | НТм-24-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("*Написать консольную программу на C#                                      *");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


string path = $@"{Directory.GetCurrentDirectory()}\DataSprint5\InPutDataFileTask7V14.txt";


string result = ds.LoadDataAndSave(path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Находится в файле " + result);