﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if ((car.Description.Length >= 2) && (car.DailyPrice > 0))
            {

                _carDal.Add(car);

                Console.WriteLine("Car Added" + car.Description);

            }

            else
            {

                Console.WriteLine("The car couldn't get added ");

            }
        }

        public void Delete(Car car)
        {

            _carDal.Delete(car);
            Console.WriteLine("Deleted" + car.Description);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

      

        public Car GetById(int Id)
        {
            return _carDal.Get(p => p.Id == Id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Updated" + car.Description);
        }
    }
}
