using System;


namespace Exercise_2
{
    enum Parking
    {
        Put_car = 1,
        Find_car,
        Remove_car,
        List_all,
        End_day,
        Exit
    }
    class Menu
    {
       
        CarCollection<Car> ParkingCar = new CarCollection<Car>();
        private void MenuItem(int menu_number)
        {

            Parking parking = (Parking)menu_number;

            switch (parking)
            {
                case Parking.Put_car:
                    {
                        Console.Clear();
                        Console.WriteLine("Введите модель авто");
                        string car_brand = Console.ReadLine();
                        Console.WriteLine("Введите год выпуска авто");
                        int year_release = Convert.ToInt32(Console.ReadLine());
                        Car new_car = new Car(car_brand, year_release);
                        ParkingCar.AddCars(new_car);
                        break;
                    }
                case Parking.Find_car:
                    {
                        Console.Clear();
                        if(ParkingCar.Counter > 0)
                        {
                            Console.WriteLine("Введите номер парковочного места");
                            int parking_space = Convert.ToInt32(Console.ReadLine());
                            var car_space = ParkingCar.FindCar(parking_space);
                            Console.WriteLine(car_space);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine($"Вам нечего искать, на парковке - {ParkingCar.Counter} автомобилей");
                            Console.ReadKey();
                        }
                        break;
                    }
                case Parking.Remove_car:
                    {
                        Console.Clear();
                        Console.WriteLine("Введите номер парковочного места");
                        int parking_space = Convert.ToInt32(Console.ReadLine());
                        if(parking_space <= ParkingCar.Counter && parking_space > 0 && ParkingCar.Counter > 0) ParkingCar.RemoveCar(parking_space);
                        else
                        {
                            Console.WriteLine($"Вы хотите удалить {parking_space} место, на парковке - {ParkingCar.Counter} автомобилей");
                            Console.ReadKey();
                        }
                        
                        break;
                    }
                case Parking.List_all:
                    {
                        Console.Clear();
                        ParkingCar.ListAll();
                        break;
                    }
                case Parking.End_day:
                    {
                        Console.Clear();
                        ParkingCar.ClearAll();
                        ParkingCar.ListAll();
                        break;
                    }
                case Parking.Exit:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }

        public void SelectMenuItem()
        {
            while (true)
            {
                Console.WriteLine("Выберите пункт меню:\n1 - Парковка авто\n2 - Поиск авто\n3 - Удалить авто\n4 - Вывести полный список авто\n5 - Конец смены (удалить все авто)" +
                "\n6 - Выход из программы");

                try
                {
                    int number_item = Convert.ToInt32(Console.ReadLine());
                    MenuItem(number_item);
                }
                catch
                {
                    Console.WriteLine("Вы ввели не правильный номер меню");
                    Console.ReadKey();
                }
                
                Console.Clear();
            }
            
        }
    }
}
