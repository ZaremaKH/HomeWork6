// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void InputArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


int CountNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

Console.Write("Введите количество элементов массива:");
int elementsCount = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elementsCount];
InputArray(array);
Console.Write("Вывод массива: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество чисел больше нуля = {CountNums(array)}");