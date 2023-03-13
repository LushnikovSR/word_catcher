﻿// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Пример:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

using System.Text.RegularExpressions;

Console.Clear();
Console.WriteLine("Введите текст: ");
string baseInput = Console.ReadLine();
string textNoPunctuation = RemovePunctuationMarks(baseInput);

string RemovePunctuationMarks(string inText)
{
    return Regex.Replace(inText, "[!\"#$%&'()*+,-./:;<=>?@\\[\\]^_`{|}~]", " ");
}

Console.WriteLine(textNoPunctuation);