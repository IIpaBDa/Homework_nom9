//Семинар 9.
//Домашнее задание.
//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"
//Выполнил: Кельт Дмитрий Владимирович (kelt_1981@mail.ru)
//Решение:

int ReadInt(string argument) 
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Введите числовое значение!");
        Console.Write(argument);
    }
    return i;
}
string NumbersRec1(int m, int n)
{
    if (m < n + 1) return $"{m} " + NumbersRec1(m + 1, n);
    else return String.Empty;
}
int m = ReadInt("Введите M: ");
int n = ReadInt("Введите N: ");
System.Console.WriteLine(NumbersRec1(m, n));
