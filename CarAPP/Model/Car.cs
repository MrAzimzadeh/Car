using System.Linq;
namespace CarApp.model
{
    public class Car
    {
        //field

        public string Brand { get; set; }
        public string Marka { get; set; }

        public decimal MaxFuel { get; set; }

        public decimal FuelEffect { get; set; }

        public decimal CurrentFuel { get; set; }

        public decimal Milleage { get; set; }


        public Car(string brand, string marka, decimal maxFuel, decimal currentFuel, decimal fuelEffect = 12, decimal milleage = 0)
        {
            Brand = brand;
            Marka = marka;
            MaxFuel = maxFuel;
            CurrentFuel = currentFuel;
            Milleage = milleage;
            FuelEffect = fuelEffect;
        }

        // CTOR


    }
}
