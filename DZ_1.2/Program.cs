// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 ИНДЕКСЫ!!! 7 + 12 = 19
// [-4, -6, 89, 6] -> 0

int[] RandomArray(int lenght, int min, int max)
{
    int [] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int SumArray(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        count += array[i];
    }
    return count;
}



int[] array = RandomArray(10, 0, 5);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {SumArray(array)}");