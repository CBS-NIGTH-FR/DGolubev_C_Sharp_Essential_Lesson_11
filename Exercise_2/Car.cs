using System;


namespace Exercise_2
{
    class Car : ICar<Car>
    {
       
        public string CarBrand { get; private set; }

        public int YearRelease { get; private set; }
                
         
        public Car(string car_brand, int year_release)
        {
            CarBrand = car_brand;
            YearRelease = year_release;
        }

        public Car NewCar(string car_brand, int year_release)
        {
            Car NewCar = new Car(car_brand, year_release);
            return NewCar;
        }

        public override string ToString()
        {
            return CarBrand + " " + YearRelease;
        }



    }
}
