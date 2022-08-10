using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_10._08._2022.Models
{
    class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelFor1Km;
        public int FuelCapacity;
        public int CurrentFuel;


        public Car(int year, string Brand, string Model, int FuelFor1Km, int FuelCapacity) : base(year) 
        {
            this.Brand = Brand;
            this.Model = Model;
            this.FuelFor1Km = FuelFor1Km;
            this.FuelCapacity = FuelCapacity;

        }
        public Car(int year, string Brand, string Model, int FuelFor1Km, int FuelCapacity, int CurrentFuel) : this(year, Model, Brand, FuelFor1Km, FuelCapacity)
        {
            this.CurrentFuel = CurrentFuel;
        }

        public Car(string color,int year, string Brand, string Model, int FuelFor1Km, int FuelCapacity) : base(color, year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.FuelFor1Km = FuelFor1Km;
            this.FuelCapacity = FuelCapacity;

        }
        public Car(string color, int year, string Brand, string Model, int FuelFor1Km, int FuelCapacity, int CurrentFuel) : this(color, year, Model, Brand, FuelFor1Km, FuelCapacity)
        {
            this.CurrentFuel = CurrentFuel;  
        }


        public int Drive(int DrivenRoad, int FuelFor1Km, int CurrentFuel)
        {
            if (FuelFor1Km * DrivenRoad <= CurrentFuel) return CurrentFuel - FuelFor1Km * DrivenRoad;// The fuel that is spent to the drivenRoad is less than the CurrentFuel
            else return -1; // The fuel that is spent to the drivenRoad is bigger than the CurrentFuel
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Color:{color}\nYear:{year}\nBrand:{Brand}\nModel:{Model}\nFuelCapacity:{FuelCapacity}\nFuelFor1Km:{FuelFor1Km}\nCurrentFuel:{CurrentFuel}");
        }
    }
}
