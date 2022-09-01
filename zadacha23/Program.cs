// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int [] Kub(int n)
{
    int [] num = new int[n];
    int index = 0;
    for(int a = 1; a < n+1; a++)
    {
        num[index] = a*a*a;
        index ++;
    }
    return num;
}
// //метод вывода массива в консоль
void ShowMassive(int[] massive, int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(massive[i]);
        Console.Write(" ");
    }
}
Console.Write("Введите чило N: ");
int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine Kub(N);
// int[] newMassive = Kub(N);
// ShowMassive(newMassive, N);
int [] result = Kub(N);
ShowMassive(result, N);
