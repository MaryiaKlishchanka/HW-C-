// Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//ссиве.

int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);  
}


void FillArray(int[] array)
{
    Random rnd= new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(100, 999);  
}

int FindNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count ++;
    }
    return count;   
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}

int size = InputNum("Введите размер массива: ");
int[] array = new int [size];
FillArray(array);
PrintArray(array);
int count = FindNum(array);
Console.WriteLine($"Количество четных чисел в массиве = {count}");
      