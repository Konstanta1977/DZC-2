// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число от 1 до 7");
// int x = Convert.ToInt32 (Console.ReadLine());
// if (x == 1) Console.WriteLine ("Рабочий день!");
// else if (x == 2) Console.WriteLine ("Рабочий день!");
// else if (x == 3) Console.WriteLine ("Рабочий день!");
// else if (x == 4) Console.WriteLine ("Рабочий день!");
// else if (x == 5) Console.WriteLine ("Рабочий день!");
// else if (x == 6) Console.WriteLine ("Выходной день!");
// else if (x == 7) Console.WriteLine ("Выходной день!");
// else Console.WriteLine("Введенный день не корректный");

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обращаться к числу как к строке нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("Введите трёхзначное целое число");
// int x = Convert.ToInt32(Console.ReadLine());
// int n = x;
// if (x <= 9)
// {
//     Console.WriteLine("Второй цифры нет");
// }
// else
// {
//     while (x>99)
//     {
//         x = x / 10;
//     }
//     int result = x % 10;
//     Console.WriteLine($"{result} является второй цифрой от числа {n}");
//  }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Обращаться к числу как к строке нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());
int n = x;
if (x <= 99)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (x>999)
    {
        x = x / 10;
    }
    int result = x % 10;
    Console.WriteLine($"{result} является третьей цифрой от числа {n}");
}