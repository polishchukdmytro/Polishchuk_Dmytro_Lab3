using System;
using System.Collections.Generic;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введiть текст:");
            string text = Console.ReadLine();
            string[] textArr = text.Split(' ');
            var textCollection = new List<string>(textArr.Length);
            for (int i = 0; i < textArr.Length; i++)
                textCollection.Add(textArr[i]);
            Console.WriteLine("\nКiлькiсть елементiв в колекцiї: " + textCollection.Count);

            Console.Write("\nВедiть порядковий номер елемента:\t");
            int serialNumber = Convert.ToInt32(Console.ReadLine());
            if (serialNumber <= 0 || serialNumber > textCollection.Count)
                Console.WriteLine("\nПомилка!");
            else
            {
                Console.WriteLine("\nВведiть напрямок, в якому бажаєте вивести елементи(->|<-):\t");
                string direction = Console.ReadLine();
                Console.WriteLine();
                if (direction == "<-")
                    for (int i = serialNumber - 1; i >= 0; i--)
                        Console.Write(textCollection[i] + " ");
                else if (direction == "->")
                    for (int i = serialNumber - 1; i < textCollection.Count; i++)
                        Console.Write(textCollection[i] + " ");
                else
                    Console.WriteLine("\nПомилка!");
            }

            Console.ReadKey();
        }
    }
}
