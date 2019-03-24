using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFirst = "qwertyfghqwert";
            var textArray = textFirst.ToCharArray();
            var a = '@';
            var b = '*';
            for (int i = 0; i < textArray.Length; i++)
            {
                for (int j = i + 1; j < textArray.Length; j++)
                {
                    if (textArray[i] == textArray[j])
                    {
                        textArray[i] = a;
                        textArray[j] = a;
                    }
                }
            }
            Console.WriteLine($"Первоначальная строка {textFirst}");
            Console.Write($"Строка после обнаружения совпадений ");
            Console.WriteLine(textArray);
            var textSecond = textArray;
            for (int k = 0; k < textSecond.Length; k++)
            {
                if (textArray[k] != a)
                {
                    textArray[k] = b;
                }
            }
            Console.Write($"Строка после замены на звездочку ");
            Console.WriteLine(textSecond);
            Console.ReadLine();
        }
    }
}
