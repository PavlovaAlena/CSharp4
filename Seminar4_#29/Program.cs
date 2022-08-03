//Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран (вводим массив с клавиатуры (т. е. через консоль)).

//************************
void input_array(int[] arr)
{
    Console.WriteLine($"Введите числа для массива из {arr.Length}-ми элементов");

    for (int i = 0; i < arr.Length;)
    {
        Console.Write($"{i + 1}й элемент массива ");
        if (int.TryParse(Console.ReadLine(), out int itemp))
        {
            arr[i] = Convert.ToInt32(itemp);
            i++;
        }
        else
        {
            Console.Write("Элемент должен быть числовой! Введите еще раз ");
        }
    }
}

//************************
Console.Write("Программа задаёт массив с клавиатуры из 8 элементов и выводит его на экран");
Console.WriteLine("");

int[] array = new int[8];
input_array(array);

Console.WriteLine($"Введен следующий массив [{string.Join(", ", array)}]");