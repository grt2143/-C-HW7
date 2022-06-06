// : Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце


Console.WriteLine("Введите количество строк в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
int [,]arr=new int [n, m];
int []sum=new int [m];
Random rnd = new Random();
Console.WriteLine();

for (int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        arr[i, j] = rnd.Next(0, 100);

        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i=0; i<m; i++)
{
    for(int j=0; j<n; j++)
    {
        sum[i] += arr[j, i];
    }
}
Console.WriteLine();
for (int i=0; i<m; i++)
{
    Console.Write((sum[i] / n)  + " ");
}