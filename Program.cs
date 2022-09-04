// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

int[] CreateArr(int n)
{
    Random random = new Random();
    int[] newArray = new int[n];
    for (int i = 0; i < n; i++)
    {
        newArray[i] = random.Next(0, 100);
    }
    return newArray;
}
void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");

    }
}
PrintArr(CreateArr(8));

