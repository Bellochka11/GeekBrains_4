// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет 3; массив [6, 7, 19, 345, 3] -> да
int[] GetArray(int size, int minValue, int maxValue) // размер массива, положит и отрицат значение
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void FindNumber(int[] array, int num)
{
    string answer = "Нет";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            answer = "Да";
            break;
        }
    }
    Console.WriteLine(answer);
}

int[] array = GetArray(8, -9, 9); // размер массива, положит и отрицат значение
Console.WriteLine(String.Join(" ", array));
FindNumber(array, 4); // Найти 4