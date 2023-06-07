// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//массив с пользовательским вводом (универсальный)
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

//вывод массива на экран (универсальный)
void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else
        {
            Console.Write($"{arr[i]}");
        }
    }
}

//сумма элементых с нечетными индексами
int SumNotEventIndex(int[] arr)
{
    int sum=0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum=arr[i]+sum;
    }
    return sum;
}



int[] array = CreateArrayRndInt(12, 1, 99);
Console.Write("[");
PrintArray(array, ";");
Console.Write("]");

Console.Write($" Cумма элементых с нечетными индексами = {SumNotEventIndex(array)} ");