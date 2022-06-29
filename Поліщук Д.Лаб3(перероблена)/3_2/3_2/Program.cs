using System;
using System.Collections.Generic;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, string> UkrainianEnglish = new Dictionary<string, string>
            {
                ["вода"] = "water",
                ["книжка"] = "book",
                ["ручка"] = "pen",
                ["яблоко"] = "apple",
                ["поляна"] = "meadow"
            };
            Dictionary<string, string> UkrainianPolish = new Dictionary<string, string>
            {
                ["сукня"] = "płótnо",
                ["книжка"] = "książka",
                ["ручка"] = "długopis",
                ["квітка"] = "kwiat",
                ["вікно"] = "okno"
            };
            Dictionary<string, string> UkrainianSpanish = new Dictionary<string, string>
            {
                ["вода"] = "agua",
                ["книжка"] = "libro",
                ["ліс"] = "bosque",
                ["сукня"] = "tela",
                ["поляна"] = "claro"
            };
            Dictionary<string, string> UkrainianGerman = new Dictionary<string, string>
            {
                ["вода"] = "Wasser",
                ["книжка"] = "Buchen",
                ["ручка"] = "Griff",
                ["вікно"] = "Fenster",
                ["поляна"] = "Clearing"
            };
            Dictionary<string, string>[] arrayOfDictionaries = { UkrainianEnglish, UkrainianGerman,
                UkrainianPolish, UkrainianSpanish};

            Console.Write("Введiть слово українською:\t");
            string inputedWord = Console.ReadLine();
            Console.WriteLine();

            int counter = 0;
            for (int i = 0; i < arrayOfDictionaries.Length; i++)
            {
                if (arrayOfDictionaries[i] == UkrainianEnglish && UkrainianEnglish.ContainsKey(inputedWord))
                {
                    Console.WriteLine($"Знайдено переклад на англiйську:\t{UkrainianEnglish[inputedWord]}");
                    counter++;
                }
                else if (arrayOfDictionaries[i] == UkrainianGerman && UkrainianGerman.ContainsKey(inputedWord))
                {
                    Console.WriteLine($"Знайдено переклад на нiмецьку:\t{UkrainianGerman[inputedWord]}");
                    counter++;
                }
                else if (arrayOfDictionaries[i] == UkrainianPolish && UkrainianPolish.ContainsKey(inputedWord))
                {
                    Console.WriteLine($"Знайдено переклад на польську:\t{UkrainianPolish[inputedWord]}");
                    counter++;
                }
                else if (arrayOfDictionaries[i] == UkrainianSpanish && UkrainianSpanish.ContainsKey(inputedWord))
                {
                    Console.WriteLine($"Знайдено переклад на iспанську:\t{UkrainianSpanish[inputedWord]}");
                    counter++;
                }
            }

            if (counter == 0)
                Console.WriteLine("\nВiдсутнiй переклад для даного слова.");
            else
                Console.WriteLine("\nЗнайдено {0} вiдповiдники.", counter);

            Console.ReadKey();
        }
    }
}
