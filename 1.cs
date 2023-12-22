using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("введите число");
        int n = Convert.ToInt32(Console.ReadLine()); //вводим число n с клавиатуры

        int product = 1; //переменная для хранения произведения

        for (int i = 3; i <= n; i += 3) //проходим по всем числам от 3 до n с шагом 3
        {
            product *= i; //умножаем произведение на текущее число
        }

        Console.WriteLine(product); //выводим полученное произведение
    }
}