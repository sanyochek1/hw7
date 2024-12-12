using System;

class Program
{
    static string ReverseString(string input)
    {
        // преобразование строки в массив из символов, реверсирование
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Домашнее задание №2");
        // примеры для тестирования метода
        string[] testStrings =
        {
            "Hello, World!",
            "приветпока",
            "а роза упала на лапу азора",
            "qwertyuiop",
            "когда-нибудь я сделаю домашку по С# на максимум",
            ""
        };

        // тестирование метода
        foreach (string test in testStrings)
        {
            string reversedStr = ReverseString(test);
            Console.WriteLine($"Исходная строка: '{test}' | Реверсированная строка: '{reversedStr}'");
        }
    }
}