using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11.Vehicle
{
    enum Fuel
    {
        Gasoline, Electric, Diesel, GPL
    }
    internal class Vehicle 
    {
        private readonly Guid id;
        public string model;
        private Fuel fuel;

        public Vehicle ( string model,Fuel fuel)
        {
            this.model = model;
            this.fuel = fuel;
        }


    }

    interface IGasoline
    {
        void Filling_UpGas(int Lt);
    }

    interface IElectric
    {
        void Charging_Up(int wats);
    }
    interface IDiesel 
    {
        void Filling_UpDiesel(int Lt);
    }
    interface IGPL
    {
        void Filling_UpGPL(int m3);
    }

    class vehicle_Gasoline :Vehicle, IGasoline
    {
        public vehicle_Gasoline(string model) : base( model, Fuel.Gasoline)
        {
            
        }

        public void Filling_UpGas(int Lt)
        {
           Console.WriteLine($"It was filled {Lt} of gasoline.");
        }
    }
    class vehicle_Hybrid : Vehicle, IElectric, IGasoline
    {
        public vehicle_Hybrid(string model) : base(model, Fuel.Electric)
        {
            
        }

        public void Charging_Up(int wats)
        {
            Console.WriteLine($"It was charged {wats} kwh on your car.");
        }

        public void Filling_UpGas(int Lt)
        {
            Console.WriteLine($"It was filled {Lt} of gasoline.");
        }
    }
    class vehicle_Diesel : Vehicle, IDiesel
    {
        public vehicle_Diesel(string model) : base(model, Fuel.Diesel)
        {

        }

        public void Filling_UpDiesel(int Lt)
        {
            Console.WriteLine($"It was filled {Lt} of diesel.");
        }
    }
    class vehicle_GPL : Vehicle, IGPL
    {
        public vehicle_GPL(string model) : base(model, Fuel.GPL)
        {

        }

        public void Filling_UpGPL(int m3)
        {
            Console.WriteLine($"It was filled {m3} of gpl.");
        }
    }
   
}
