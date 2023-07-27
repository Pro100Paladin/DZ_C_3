/*Задача 19 
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом(первое == последнему, второе == предпоследнему).
14212 -> нет
12821 -> да
23432 -> да*/


Console.WriteLine("Введите пятизначное число: ");
string fivenumber = Console.ReadLine()!;
int dlina = fivenumber.Length;

if (dlina == 5)
{
    if (fivenumber[0] == fivenumber[4] && fivenumber[1] == fivenumber[3])
    {
        Console.WriteLine($"{fivenumber} - Да - это палиандром");
    }
    else
    {
        Console.WriteLine($"{fivenumber} - Нет, это не палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {fivenumber} - не является пятизначным числом по условию задачи");
}