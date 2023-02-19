// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetArray(int size, int minValue, int maxValue) // размер массива, положит и отрицат значение
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void Convert(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int[] array = GetArray(12, -9, 9); // размер массива, положит и отрицат значение
Console.WriteLine(String.Join(" ", array));
Convert(array);
Console.WriteLine(String.Join(" ", array));