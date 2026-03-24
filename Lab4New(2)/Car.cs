using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using static Lab4New_2_.Box;

namespace Lab4New_2_
{
    internal class Car
    {
        public string Name { get; set; }
        public Engine Engine { get; set; }

        public Box? box { get; set; }
        public int Needpas
        {
            get => needpas;
            set => needpas = value > 0 ? value : 1;
        }

        private int needpas;

        public Car() : this("Безымянная")
        {
        }

        public Car(string name) : this(name, "СК1154", 1)
        {
        }

        public Car(string name, string engine, int needpas)
        {
            Name = name;
            Engine = new Engine(engine);
            Needpas = needpas;
        }
        public ResultRequest LandingRequest(Box box)
        {
            return box.hightlightRunway(this);
        }

        public Driver.lockcar WhatCarUse(Driver driver)
        {
            return driver.IslockCar(this);
        }

        public override string? ToString()
        {
            return $"Автомобиль: {Name}, двигатель: {Engine.Name}. " +
                (box == null ? "Гаража в резерве нет" : $"Зарезервирован гараж {box.Name}");
        }
    }
}
