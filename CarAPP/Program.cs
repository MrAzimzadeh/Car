using System.ComponentModel;
using CarApp.model;
using CarApp.Service;
using CarApp.helper;

Car bmw = new("BMW", "M5 ", 60, 16, 15);

CarService carService = new();
// bmw.Marka = " M5 ";
// bmw.MaxFuel = 60 ;
// bmw.CurrentFuel = 15;
// bmw.FuelEffect =  15;

int userInput;

do
{
    System.Console.WriteLine("wELCOME");

    System.Console.WriteLine(" 1 go");
    System.Console.WriteLine("2 . fuel");
    System.Console.WriteLine("3 . Infor");

    System.Console.WriteLine(">>>>>");

    userInput = Convert.ToInt32(Console.ReadLine());
    switch (userInput)
    {
        case 1:
            System.Console.WriteLine(" how many km.. .");
            System.Console.WriteLine(">>>>>");
            string milleage = Console.ReadLine();
            if (Utilitis.Convertor(milleage))
            {
                decimal mil = Convert.ToDecimal(milleage);
                carService.Go(bmw, mil);
            }
            break;
        case 2:

            System.Console.WriteLine(" go to fuel ");
            System.Console.WriteLine(">>>>>");
            string fuel = Console.ReadLine();
            if(Utilitis.Convertor(fuel)){
                decimal full = Convert.ToDecimal(fuel);
                carService.Go(bmw, full);
            }

            //decimal fuel = Convert.ToDecimal(Console.ReadLine());
            // carService.ReFuel(bmw, fuel);
            break;
        case 3:
            System.Console.WriteLine(bmw.Milleage);


            System.Console.WriteLine();

            break;
        case 4:
            break;

        default:
            System.Console.WriteLine(" 1 and 4 ; ");
            break;
    }
} while (userInput != 4);