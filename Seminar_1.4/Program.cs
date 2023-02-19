// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в 
// отрезке [10,99].Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0 [10, 11, 12, 13, 14] -> 5

int[] GetArray(int size, int minValue, int maxValue) // размер массива, положит и отрицат значение
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int countElement (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        count++;
    }
    return count;
}



int[] array = GetArray(123, 0, 150); // размер массива, положит и отрицат значение
Console.WriteLine(String.Join(" ", array));
int count = countElement(array);
Console.WriteLine(count);