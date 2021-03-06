﻿using System;

namespace Polymorphism_Dynamic
{
    public class HybridCar : ICar
    {
        public int BatteryLifeMonths { get; set; }
        public int BatteryDuration { get; set; }
        public string MotorNumber { get; set; }
        public HybridCar()
        {
            MotorNumber = this.MotorNumber + "-H"; // H - for hybrid
        }
        public HybridCar(string engineNumber)
        {
            MotorNumber = engineNumber + "-H";
        }
        public void Refuel()
        {
            Console.WriteLine("Hybrid refueling: Petrol or Battery");
        }
    }
}