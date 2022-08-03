//Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе 

//************************
int sum_digit(int A)
{
    int result = 0;
    int numCalc = Math.Abs(A);
    while (numCalc / 10 > 0)
    {
        result = result + numCalc % 10;
        numCalc = numCalc / 10;
    }
    result = result + numCalc;
    return result;
}

//************************
Console.Write("Программа принимает на вход число и выдаёт сумму цифр в числе");
Console.WriteLine("");
Console.Write("Введите число ");
int A = Convert.ToInt32(Console.ReadLine());

int sum = sum_digit(A);

Console.WriteLine($"В числе {A} сумма цифр = {sum}");