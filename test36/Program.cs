// Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позиция

int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);  
}


void FillArray(int[] array)
{
    Random rnd= new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(1, 100);  
}

int FindSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;   
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int size = InputNum("Введите размер массива: ");
int[] array = new int [size];
FillArray(array);
PrintArray(array);
int sum = FindSum(array);
Console.WriteLine($"сумма элемнтов с нечетными индексами = {sum}");
      