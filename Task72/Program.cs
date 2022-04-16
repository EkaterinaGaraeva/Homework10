/*
Задача 72: Заданы 2 массива: info и data. В массиве info хранятся 
двоичные представления нескольких чисел (без разделителя). 
В массиве data хранится информация о количестве бит, 
которые занимают числа из массива info. Напишите программу, 
которая составит массив десятичных представлений чисел массива data 
с учётом информации из массива info.

входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1
*/

int[] DecimalData(int[] data, int[] info, int count = 0)
{
    int[] decimalNumbers = new int[info.Length];
    for (int i = 0; i < info.Length; i++)
    {
        while (info[i] - 1 >= 0 && count < data.Length)
        {
            decimalNumbers[i] += data[count] * (int)Math.Pow(2, info[i] - 1);
            info[i]--;
            count++;
        }
    }
    return decimalNumbers;
}

void PrintArray(int[] incomingArray)
{
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i != incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] decimalArray = DecimalData(data, info);
PrintArray(decimalArray);

int[] data2 = { 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1 }; // 15, 22, 2, 4, 11
int[] info2 = { 4, 5, 2, 3, 4 };
int[] decimalArray2 = DecimalData(data2, info2);
PrintArray(decimalArray2);

int[] data3 = { 1, 1, 1, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, 0, 1, 1, 0, 0 }; // 3, 5, 9, 18, 108
int[] info3 = { 2, 3, 4, 5, 7 };
int[] decimalArray3 = DecimalData(data3, info3);
PrintArray(decimalArray3);
