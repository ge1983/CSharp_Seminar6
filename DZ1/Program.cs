// 
int[] InputArray (int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int findToArray (int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0 )
        {
            counter++;
        }
    }
    return counter;
}

Console.WriteLine("Введите количество элеменов");
int length = Convert.ToInt32(Console.ReadLine()); 
int[] array = InputArray(length);
Console.WriteLine("Введеные числа: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество положительных введеных чисел - {findToArray (array)}");

