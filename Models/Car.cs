using System.Collections.Generic;
using System;

namespace CarDealer.Models
{
  public class Car
  {
    private string _brand;
    private string _model;
    private int _price;
    private static List<Car> _instances = new List<Car>{};

    public Car(string brand, string model, int price)
    {
      _brand = brand;
      _model = model;
      _price = price;
    }

    public string GetBrand()
    {
      return _brand;
    }
    public void SetBrand(string newBrand)
    {
      _brand = newBrand;
    }
    public string GetModel()
    {
      return _model;
    }
    public void SetModel(string newModel)
    {
      _model = newModel;
    }
    public int GetPrice()
    {
      return _price;
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
        public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
