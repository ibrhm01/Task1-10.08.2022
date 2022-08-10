using System;
using Task1_10._08._2022.Models;

namespace Task1_10._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {

            Car Mercedes = new Car("Blue", 2005, "Mercedes", "S-Class", 1, 70, 60);
            Mercedes.ShowInfo();
            int DrivenRoad = int.Parse(Console.ReadLine());
            Console.WriteLine(Mercedes.Drive(DrivenRoad, Mercedes.FuelFor1Km, Mercedes.CurrentFuel));

        }
    }
}
