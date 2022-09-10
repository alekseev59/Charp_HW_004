// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] ArrayInit(int enterNum)
{
    int[] array = new int[enterNum];
    var rndm = new Random();
    for (int i = 0; i < enterNum; i++)
    {
        array[i] = new Random().Next(0, 33);
    }
    return array;
}

Console.Write("Введите число, для задания массива: ");
int enterNum = Convert.ToInt32(Console.ReadLine());
int[] result = ArrayInit(enterNum);
Console.WriteLine($"[{string.Join(", ", result)}]");