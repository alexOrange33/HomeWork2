// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.  
// Обязательна проверка на ввод числа <1 и >7

// 6 -> да
// 7 ->  да
// 1 -> нет

Console.Write("Введите цифру обозначающую день недели: ");
int date = int.Parse(Console.ReadLine()!);

if(date < 1 || date >7)
{
    Console.WriteLine("Введена не корректная цифра!");
}
else
{
    if(date == 6 || date == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}