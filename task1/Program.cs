// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
Console.WriteLine("Введите строки через пробел");
string element = Console.ReadLine();
string[] array = element.Split(' '); ;
var result = new string[array.Length];
var count = 0;
foreach (var value in array)
{
    
    if (value.Length <= 3)
    {
        result[count] = value;
        count++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, count));