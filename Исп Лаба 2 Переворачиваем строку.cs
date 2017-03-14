
using System;

class ReverseWords
{
    static void Main(string[] args)
    {
        Console.WriteLine("Перевернем вашу строку.\n\nВведите несколько слов через пробел: ");
        string[] text = Console.ReadLine().Split(); // Разбивает строку на подстроки .

        Array.Reverse(text);//Изменяет порядок элементов во всем одномерном массиве Array на обратный.

        Console.WriteLine("Наоборот: ");
        for (int i = 0; i < text.Length; i++)
            Console.Write(text[i] + " ");
        Console.Write("\n");
        Console.ReadLine();

    }

}
