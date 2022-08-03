//Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int pow_for(int A, int B)
{
    int res = 1;
    if (B == 0)
    { res = 1; }
    else if (B == 1)
    { res = A; }
    else
    {
        for (int i = 1; i <= B; i++)
        { res = res * A; }
    }

    return res;
}

Console.Write("Программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B");
Console.WriteLine("");
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = pow_for(A, B);

Console.WriteLine($"Результат возведения числа А({A}) в степень В({B}) = {result}");