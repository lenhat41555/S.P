using System;

namespace S.P
{
   public class Program
    {
        static void Main(string[] args)
        {
           Car car1 = new Car("Mazda 3", "Skyactiv 3");
          Console.WriteLine(Car.numberOfCars);
          Car car2 = new Car("Mazda 6", "Skyactiv 6");
          Console.WriteLine(Car.numberOfCars);
          Console.ReadLine();

        }
    }
}