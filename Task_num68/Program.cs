//Семинар 9.
//Домашнее задание.
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
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
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = ReadInt("Введите M: ");
int n = ReadInt("Введите N: ");
System.Console.WriteLine(Akkerman(m, n));

