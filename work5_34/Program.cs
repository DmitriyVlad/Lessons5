// Задача 34. Необходимо подсчитать кол-во четных трехзначных чисел в заданном массиве

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int i = 0;
int a = 0;
int sum = 0;
while (i < arr.Length)
{
    arr[i] = new Random().Next(100, 999);
    i++;
}
Console.WriteLine("Наш массив:");
for (int k = 0; k < arr.Length; k++)
{
    Console.Write(arr[k] + " ");
}
Console.WriteLine();

while (a < arr.Length)
{
   if(arr[a] % 2 == 0)
    {
        sum++;
        a++;
    }
    else 
    {
        a++;
    }
}

Console.WriteLine("Количество четных чисел в массиве - " + sum);
