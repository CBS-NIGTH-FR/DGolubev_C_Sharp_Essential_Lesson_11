using System;
using System.Collections;


namespace Additional_Task
{
    class MyClass
    {
        public int Number { get; set; }
    }
    class Program
    {
        // Все элементы ArrayList приведены к object, нет возможности обратиться к свойствам напрямую.
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("String");
            list.Add(0.67);
            list.Add('5');
            list.Add(false);
            list.Add(new MyClass());
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
