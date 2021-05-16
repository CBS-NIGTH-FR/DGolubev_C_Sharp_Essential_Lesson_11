using System;
using System.Collections.Generic;


namespace Exercise_2
{

    class CarCollection<T> where T : Car
    {
        private List<T> CarList { get; set; }
        public int Counter => CarList.Count;
        public CarCollection()
        {
            CarList = new List<T>();
        }
        public int AddCars(T new_car)
        {
            Console.WriteLine($"Всего на парковке {Counter} автомобилей");
            CarList.Add(new_car);
            return CarList.Count;
        }

        public T FindCar(int index)
        {
            return CarList[index - 1];
        }

        public void RemoveCar(int index)
        {
            ListAll();
            CarList.RemoveAt(index - 1);
            ListAll();
        }
        public void ListAll()
        {
            Console.WriteLine($"Всего на парковке {Counter} автомобилей");
            int count = 1;
            foreach (var item in CarList)
            {
                Console.WriteLine(item);
                count++;
            }
            Console.ReadKey();
        }

        public void ClearAll()
        {
            ListAll();
            CarList.Clear();
            ListAll();
        }
        public T this[int index]
        {
            get
            {
                if (index < CarList.Count)
                {
                    return CarList[index - 1];
                }
                return CarList[index] = null;
            }
        }
    }
}
