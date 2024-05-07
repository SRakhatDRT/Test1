/*
Задайте произвольный массив. Выведете
его элементы, начиная с конца. Использовать
рекурсию, не использовать циклы.

[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1
*/   

int[] arr = {1, 2, 5, 0, 10, 34};
void PrintArray(int[] arr, int i)
{
    if (i < 0)
    {
        return;
    }
    {
        System.Console.Write(arr[i] + " ");
        PrintArray(arr, i - 1);
    }
}
PrintArray(arr, arr.Length - 1);
