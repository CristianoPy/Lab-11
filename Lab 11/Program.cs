using Lab_11.Fuel_Station;
using Lab_11.Vehicle;

var wolkswagen = new vehicle_Gasoline("golf");
var mitsubish = new vehicle_Hybrid("outlander");
var ford = new vehicle_Diesel("transit");
var mustang = new vehicle_GPL("gt");

var fuel_station = new Fuel_Station();

fuel_station.Filling_UpGas(wolkswagen, 25);
fuel_station.Charging_Up(mitsubish, 10);
fuel_station.Filling_UpDiesel(ford, 70);
fuel_station.Filling_UpGPL(mustang, 25);