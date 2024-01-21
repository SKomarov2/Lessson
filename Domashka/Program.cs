// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine ($"Число: {number} -- кратно");
// }
// else
// {
//     Console.WriteLine ($"Число {number} НЕ кратно");
// }

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0  && y > 0)
// {
//     Console.WriteLine ($"1 четверть");
// }
// if (x < 0  && y > 0)
// {
//     Console.WriteLine ($"2 четверть");
// }
// if (x < 0  && y < 0)
// {
//     Console.WriteLine ($"3 четверть");
// }
// if (x > 0  && y < 0)
// {
//     Console.WriteLine ($"4 четверть");
// }
// if (x == 0  && y == 0)
// {
//     Console.WriteLine ($"Ошибка нужны координаты не равные нулю");
// }


// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Console.Write("Введите число от 10 до 99: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;
// if (number >= 10 && number <= 99 )
// {
//     int firstnumber = number / 10;
//     int thiridnumber = number % 10;
//     if (firstnumber>thiridnumber)
//     {
//         Console.WriteLine ($"Наибольшая цифра числа {copyNumber} => {firstnumber} > {thiridnumber}");
//     }
//     if (firstnumber<thiridnumber)
//     {
//         Console.WriteLine ($"Наибольшая цифра числа {copyNumber} => {thiridnumber} > {firstnumber}");
//     }
//     if (firstnumber==thiridnumber)
//     {
//         Console.WriteLine ($"Цифры числа {copyNumber} равны  {thiridnumber} = {firstnumber}");
//     }
// }
// else
// {
//     Console.WriteLine ("Число НЕ от 10 до 99");
// }


// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

// Console.Write("Введите натуральное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 10)
// {
// Console.WriteLine(N);
// }
// else
// {
//     while (N > 0)
//     {
//     int currentN= N % 10;
//     N /= 10;
//     if (N > 0)
//     {
//         Console.Write(currentN + ",");
//     }
//     else
//     {
//         Console.WriteLine(currentN);
//     }
//     }
// }   