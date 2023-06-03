//Семинар 9.
//Домашнее задание.
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
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
int SumNumbers(int m, int n)
{
    if (n == m) return n;
    else return n + SumNumbers(m, n - 1);
}
int m = ReadInt("Введите M: ");
int n = ReadInt("Введите N: ");
if (n < m)
{
    int temp = n;
    n = m;
    m = temp;
}
System.Console.WriteLine(SumNumbers(m, n));
