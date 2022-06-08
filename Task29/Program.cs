/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] array = new int[8];

void FillArray(int[] collection)
{
    //Console.WriteLine("Введите 8 элементов, после каждого нажмите Enter: ");
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1,100); //Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] col)
{
    Console.Write("Массив из 8 элементов: [");
    for (int pos = 0; pos < col.Length; pos++)
    {
        if (pos < col.Length - 1)
        {
            Console.Write($"{col[pos]}, ");
        }
        else
        {
            Console.Write(col[pos]);
            break;
        }
    }
    Console.Write("]");
}

FillArray(array);
PrintArray(array);
Console.WriteLine();