using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> { 
                new Car{Id=1,BrandId=1 ,ColorId=1,DailyPrice=40000,ModelYear=2020,Description="Amerikan"},
                new Car{Id=2,BrandId=2 ,ColorId=3,DailyPrice=35000,ModelYear=2021,Description="Fransız"},
                new Car{Id=3,BrandId=1 ,ColorId=2,DailyPrice=20000,ModelYear=2020,Description="Alman"},
                new Car{Id=4,BrandId=3 ,ColorId=1,DailyPrice=2000,ModelYear=2021,Description="Alman"},
                new Car{Id=5,BrandId=2 ,ColorId=2,DailyPrice=60000,ModelYear=2020,Description="İtalyan"},


            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
            
        }

        public List<Car> GetByBrand(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByColor(int colorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
      

        public List<Car> GetAllByBrand(int brandId)
        {
            return _car.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _car.Where(c => c.ColorId == colorId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
