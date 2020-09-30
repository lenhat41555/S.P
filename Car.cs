using System;
namespace S.P
{
    public class Car {

private string name;
 private string engine;
 public static int numberOfCars;
 public Car(string name, string engine) {
 this.name = name;
 this.engine = engine;
 numberOfCars++;
 }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public string GetEngine()
        {
            return engine;
        }

        public void SetEngine(string value)
        {
            engine = value;
        }
    }
    }