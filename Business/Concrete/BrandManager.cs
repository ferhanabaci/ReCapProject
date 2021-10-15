using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public  class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

     

        public void AddBrand(Brand brand)
        {

            _brandDal.Add(brand);
            Console.WriteLine("Brand Added" + brand.BrandName);
        }

        public void DeleteBrand(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Brand Deleted" + brand.BrandName);
        }

        public List<Brand> GetAll()
        {
            return GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
        }

        public void UpdateBrand(Brand brand)
        {
            _brandDal.Update(brand);
            Console.WriteLine("Brand Update" + brand.BrandName);
        }

        public void Add(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
