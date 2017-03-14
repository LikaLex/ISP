using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string letters = null;

        Console.Write("Введите строку: ");
        string text = Console.ReadLine();

        foreach (char ch in text)
        {
            if (Char.IsUpper(ch) && (ch < 0x0041 || ch > 0x0079))
                letters += ch;
        }

        if (letters != null)
            Console.WriteLine("Заглавные не английские символы: " + letters);
        else
            Console.WriteLine("Нет нужных символов.");
        Console.ReadLine();
    }
}
