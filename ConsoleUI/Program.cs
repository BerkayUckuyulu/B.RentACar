using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
            //ColorAdded();
            //GetCarDetails();
            //CarAddedd();
            CarTest(); 

            //CustomerAdded();


        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
        }






    }

        //private static void GetCarDetails()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());

        //    var result = carManager.GetCarDetails();

        //    if (result.Success)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            System.Console.WriteLine(car.Description + "\n" + car.BrandName + "\n" + car.ColorName + "\n" + car.DailyPrice);
        //        }

        //    }
        //    else
        //    {
        //        System.Console.WriteLine(result.Message);
        //    }
        //}

        //private static void ColorAdded()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());

        //    colorManager.Add(new Color { ColorName = "Turuncu" });
        //    foreach (var colors in colorManager.GetAll())
        //    {
        //        System.Console.WriteLine(colors.ColorName);
        //    }
        //}

        //private static void CarAdded()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());

        //    carManager.Add(new Car { BrandId = 5, ColorId = 2, Description = "Fast", ModelYear = 2020, DailyPrice = 20000 });
        //    carManager.Add(new Car { BrandId = 7, ColorId = 1, Description = "Cheaper", ModelYear = 2019, DailyPrice = 15000 });
        //    foreach (var cars in carManager.GetAll())
        //    {
        //        System.Console.WriteLine(cars.Description + " " + cars.DailyPrice);
        //    }
        //}
}



