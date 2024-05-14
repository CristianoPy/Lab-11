using Lab_11.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11.Fuel_Station
{
    internal class Fuel_Station
    {
        public void Filling_UpGas(IGasoline vehicle_Gasoline, int Lt)
        {
            Console.WriteLine($"Filling up the vehicle{vehicle_Gasoline} with {Lt} of gasoline.");
            
        }
        public void Charging_Up(IElectric vehicle_Electric, int wats)
        {
            Console.WriteLine($"Charging the vehicle{vehicle_Electric} with {wats} kwh.");
        }
        public void Filling_UpDiesel(IDiesel vehicle_Diesel, int Lt)
        {
            Console.WriteLine($"Filling up the vehicle{vehicle_Diesel} with {Lt} of diesel.");
        }
        public void Filling_UpGPL(IGPL vehicle_GPL, int m3)
        {
            Console.WriteLine($"Filling up the vehicle{vehicle_GPL} with {m3} of diesel.");
        }
    }
}
