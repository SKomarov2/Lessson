// // тип_метода ИмяМетода (пар1, пар2)
// int Calculate(int a, int b, char sing)
// {
//     if (sing == '+')
//     {
//         return a + b;
//     }
//     else if (sing == '-')
//     {
//         return a - b;
//     }
//     else if (sing == '*')
//     {
//         return a * b;
//     }
//     else
//     {
//         Console.WriteLine("Введено неизвестное вырожение :(");
//         return 0;
//     }
// }
// // Вызов функции
// int res = Calculate(100, 350, '*');
// Console.WriteLine($"res: {res}");
// Console.WriteLine(Calculate(2, 3, '-'));
// Console.WriteLine(Calculate(2, 3, '*'));
// Console.WriteLine(Calculate(2, 3, '8'));

// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2
int[] CreateArray(int size, int minRange, int maRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maRange + 1);
    }
    return array;
}
int GetCount(int[] arr)
{
     int count = 0;
     foreach (int number in arr)
     {
        if (number %  7 == 0 && number % 10 == 1)
        {
            count++;
        }
     }
     return count;
}


Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = (CreateArray(N, 0, 100));
Console.WriteLine($"Массив:[{string.Join("; ", array)}]");
Console.WriteLine($"Total: {GetCount(array)}");