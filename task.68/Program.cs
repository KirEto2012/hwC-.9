// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

Console.WriteLine(AkkermannFunction(m,n));

int AkkermannFunction (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermannFunction(m - 1, 1);
    }
    else
    {
        return (AkkermannFunction(m - 1, AkkermannFunction(m, n - 1)));
    }
}
