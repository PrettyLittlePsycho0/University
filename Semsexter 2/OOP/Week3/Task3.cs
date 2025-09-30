using System;
using System.Collections.Generic;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RacingGameCar c1 = new RacingGameCar("Niggatron", 120, 10, 100, 0, 1, 0);
            RacingGameCar c2 = new RacingGameCar("skajh", 110, 8, 100, 0, 2, 0);

            List<RacingGameCar> cars = new List<RacingGameCar>();
            cars.Add(c1);
            cars.Add(c2);

            c1.Accelerate();
            c1.Collide();
            c1.Refuel(20);
            c1.Repair(10);
            c1.CompleteLap();

            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine(cars[i].ToString());
                Console.WriteLine();
            }
        }
    }

    class RacingGameCar
    {
        public string CarName;
        public int Speed;
        public int Acceleration;
        public int FuelLevel;
        public int DamageLevel;
        public int Position;
        public int LapCount;

        public RacingGameCar(string name, int speed, int accel, int fuel, int damage, int pos, int laps)
        {
            CarName = name;
            Speed = speed;
            Acceleration = accel;
            FuelLevel = fuel;
            DamageLevel = damage;
            Position = pos;
            LapCount = laps;
        }

        public void Accelerate()
        {
            if (FuelLevel > 0 && DamageLevel < 100)
            {
                Speed = Speed + Acceleration;
                FuelLevel = FuelLevel - 10;
                if (FuelLevel < 0)
                {
                    FuelLevel = 0;
                }
            }
        }

        public void Collide()
        {
            DamageLevel = DamageLevel + 20;
            if (DamageLevel > 100)
            {
                DamageLevel = 100;
            }
        }

        public void Refuel(int amount)
        {
            FuelLevel = FuelLevel + amount;
            if (FuelLevel > 100)
            {
                FuelLevel = 100;
            }
        }

        public void Repair(int amount)
        {
            DamageLevel = DamageLevel - amount;
            if (DamageLevel < 0)
            {
                DamageLevel = 0;
            }
        }

        public void CompleteLap()
        {
            LapCount = LapCount + 1;
        }

        public override string ToString()
        {
            return "Car: " + CarName + ", Speed: " + Speed + ", Accel: " + Acceleration + ", Fuel: " + FuelLevel + ", Damage: " + DamageLevel + ", Position: " + Position + ", Laps: " + LapCount;
        }
    }
}
