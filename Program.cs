﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите элементы(через пробел): ");
// int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во элементов > 0: {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// double b1 = ReadInt("Введите число b1: ");
// double k1 = ReadInt("Введите число k1: ");
// double b2 = ReadInt("Введите число b2: ");
// double k2 = ReadInt("Введите число k2: ");

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"Точка пересечения двух прямых X: {x}, Y: {y}");