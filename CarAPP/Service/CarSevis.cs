using CarApp.model;
namespace CarApp.Service
{
    class CarService
    {
        public void Go(Car car, decimal milleage)
        {
            decimal fuelResult = milleage * car.FuelEffect / 100;
            if (fuelResult > car.CurrentFuel)
            {
                System.Console.WriteLine(" benzinin catmir ");
            }
            else
            {
                car.CurrentFuel -= fuelResult;
                car.Milleage += milleage;
            }

        }
        public void ReFuel(Car car , decimal fuel){
                if (car.MaxFuel < car.CurrentFuel + fuel)
                {
                    System.Console.WriteLine(" this litr");
                }else{
                    car.CurrentFuel += fuel;
                }
        }
        public void gedilenYol(Car car , decimal milleage){
            
                System.Console.WriteLine(milleage);
        }
    }

}