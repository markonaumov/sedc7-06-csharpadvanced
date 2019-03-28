﻿using System;
using System.Collections.Generic;

namespace Polymorphism_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICar> cars = new List<ICar>(){
                new NormalCar("VW234KJH234"),
                new ElectricCar("VW2ERT2MM34"),
                new HybridCar("VW2ERT23JKL0")
            };

            cars[0].Refuel(); Console.WriteLine(cars[0].MotorNumber);
            cars[1].Refuel(); Console.WriteLine(cars[1].MotorNumber);
            cars[2].Refuel(); Console.WriteLine(cars[2].MotorNumber);

        }
    }
}
