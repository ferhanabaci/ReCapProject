using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
     class Program
       

    {

        static void Main(string[] args)
        {

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CarManager carManager = new CarManager(new EfCarDal());
            AddTest(brandManager, colorManager, carManager);

        }




        private static void AddTest(BrandManager brandManager,ColorManager colorManager,CarManager carManager)
        {
            carManager.Add(new Car
            {
                Id = 1,
                BrandId = 1,
                ColorId = 1,
                CarName = "Nissan micra",
                DailyPrice = 2500,
                ModelYear = 2005,
                Description = "4 silindir Motor"
            }); ;
            carManager.Add(new Car
            {
                Id = 2,
                BrandId = 2,
                ColorId = 2,
                CarName = "Mercedes",
                DailyPrice = 4000,
                Description = "200cls",
                ModelYear = 2007

            });
            carManager.Add(new Car
            {
                Id = 3,
                BrandId = 1,
                ColorId = 2,
                CarName = "polo",
                DailyPrice = 3000,
                Description = "1.4 Turbo",
                ModelYear = 2006

            });


            brandManager.Add(new Brand { BrandId = 1, BrandName = "nissan" });
            brandManager.Add(new Brand { BrandId = 2, BrandName = "mercedes" });
            colorManager.Add(new Color { ColorId = 1, ColorName = "mavi" });
            colorManager.Add(new Color { ColorId = 2, ColorName = "kırmızı" });
        }

    }
    
}
