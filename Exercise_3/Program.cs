using System;


namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary dictionary = new MyDictionary();
            dictionary.Add("Яблоко","Apple");
            dictionary.Add("Стол", "Table");
            dictionary.Add("Солнце", "Sun");
            dictionary.Add("Карандаш", "Pencil");
            dictionary.Add("Чашка", "Cap");
            dictionary.Add("Чай", "Tea");

            Console.WriteLine(dictionary.ToString());
            Console.WriteLine();
            Console.WriteLine($"В словаре {dictionary.Counter} пар слов");
            Console.WriteLine();
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();
            if (string.IsNullOrEmpty(word)) Console.WriteLine("Вы не ввели слово для поиска");
            else Console.WriteLine(dictionary[word]);

            Console.ReadKey();

        }
    }
}
