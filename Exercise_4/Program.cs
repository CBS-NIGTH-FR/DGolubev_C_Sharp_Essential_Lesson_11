using System;


namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList my = new MyArrayList();
            my.Add(1972);
            my.Add("String");
            my.Add(false);
            my.Add(3.1415);

            Console.WriteLine();
            Console.WriteLine(my.ToString());
            Console.WriteLine(my.Contains("String"));
            my.Insert(2, true);
            Console.WriteLine(my.ToString());
            my.Remove("String");
            Console.WriteLine(my.ToString());
            Console.ReadKey();
        }
    }
}
