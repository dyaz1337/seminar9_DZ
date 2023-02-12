// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int num = Input("Введите число: ");
// int m = 1;
// int Nums(int num, int m)
// {
//     if (num == m)
//         return num;
//     else
//         Console.Write($"{Nums(num, m + 1)}, ");
//     return m;
// }

// if (num < 1)
// {
//     Console.WriteLine("Ввели не положительное число");
// }
// Console.WriteLine(Nums(num, m));
// int Input(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int m = Input("Введите M: ");
// int n = Input("Введите N: ");
// Console.WriteLine($"M = {m}; N = {n} -> {Summa(m, n)}");

// int Summa(int m, int n)
// {
//     if (m == n)
//         return n;
//     return n + Summa(m, n - 1);
// }

// int Input(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int m = Input("Введите число M: ");
// int n = Input("Введите число N: ");

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     if (m > 0 && n == 0)
//         return Akkerman(m - 1, 1);
//     else
//         return Akkerman(m - 1, Akkerman(m, n - 1));
// }
// Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = {Akkerman(m, n)}");

// int Input(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }
