using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("Color Added" + color.ColorName);



        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Color Deleted" + color.ColorName);
        }

        public List<Color> GetAll()
        {
            return GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(p => p.ColorId == colorId);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Color Updated" + color.ColorName);
        }
    }
}
