//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//  натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int start, int end)
{
    if (start > end)
    {
        return 0;
    }

    return start + SumNumbers(++start, end);
}

if (M > N)
{
    Console.WriteLine($"Сумма натуральных чисел : {SumNumbers(N, M)}");
}
else if (M < N)
{
   Console.WriteLine($"Сумма натуральных чисел : {SumNumbers(M, N)}");
}
else
{
   Console.WriteLine("Введены равные числа");
}