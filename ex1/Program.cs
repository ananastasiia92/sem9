﻿/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"

using System;
using static System.Console;

Clear();
Write("Введите число N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumber(1, n));

string PrintNumber(int start, int end) {
  if (start == end) return start.ToString();
  return (start + " " + PrintNumber(start + 1, n));
}

Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */

using System;
using static System.Console;

Clear();
Write("Введите число N");
int m = int.Parse(ReadLine());
Write("Введите число N");
int n = int.Parse(ReadLine());

WriteLine(PrintNumber(m, n));

string PrintNumber(int start, int end) {
  if (start == end) return start.ToString();
  return (start + " " + PrintNumber(start + 1, n));
}

