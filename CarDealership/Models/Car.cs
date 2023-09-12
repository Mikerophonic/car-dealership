using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string Make { get; set; }
    public string Model { get; set; }
    public int Vin { get; set; }
    public int Year { get; set; }
    public int Price { get; set; }
    private static List<Car> _instances = new List<Car> { };

    public Car(string make, string model, int vin, int year, int price)
    {
      Make = make;
      Model = model;
      Vin = vin;
      Year = year;
      Price = price;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }  
}