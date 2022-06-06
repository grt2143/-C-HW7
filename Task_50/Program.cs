// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет


Console.WriteLine("Введите номер строки от 0 до 6:  ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца от 0 до 6:  ");
int pos2 = Convert.ToInt32(Console.ReadLine());
int n = 7; 
int m = 7; 
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine();
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(10, 99);
        Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}
if (pos1 < 0 | pos1 > arr.GetLength(0) | pos2 < 0 | pos2 > arr.GetLength(1))
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение выбранного элемента массива -> {0}", arr[pos1, pos2]);
}