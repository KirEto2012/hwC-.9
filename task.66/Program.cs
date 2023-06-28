// Задача 66:
// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = 1;//int.Parse(Console.ReadLine());
int n = 15;//int.Parse(Console.ReadLine());

SumOfNaturalElements(m, n);

void SumOfNaturalElements(int m, int n, int sum = 0)
{
    if (m > n)
    {
        Console.Write(sum);
        return ;
    }
    sum = sum + (m++);
    SumOfNaturalElements(m, n, sum);
}

