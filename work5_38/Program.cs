// Задача 38. Необходимо найти разницу между максимальным и минимальным значениями массива

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());
double[] arr = new double[n];
int i = 0;
int a = 0;

while (i < arr.Length)
{
    arr[i] = new Random().Next(1, 100);
    i++;
}
Console.WriteLine("Наш массив:");
double max = arr[0];
double min = arr[0];

for (int k = 0; k < arr.Length; k++)
{
    Console.Write(arr[k] + " ");
}
Console.WriteLine();

while (a < arr.Length)
{
   if(arr[a] > max)
    {
        max = arr[a];
        a++;
    }
    else 
    {
        if(arr[a] < min)
        {
        min = arr[a];
        a++;
        }
        else
        a++;
    }
}

Console.WriteLine("Максимальное значение массива :  " + max);
Console.WriteLine("Минимальное значение массива :  " + min);
Console.WriteLine("Разница между максимальным и минимальным значениями массива:  " + (max - min));
