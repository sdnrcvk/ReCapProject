using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
  //  public class InMemoryCarDal : ICarDal
    public class InMemoryCarDal
    {
        /*
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=2,ModelYear="2011",DailyPrice=160,Description="Manuel-Benzin"},
                new Car{Id=2,BrandId=2,ColorId=3,ModelYear="2000",DailyPrice=140,Description="Manuel-Benzin" },
                new Car{Id=3,BrandId=2,ColorId=1,ModelYear="2019",DailyPrice=300,Description="Otomatik-Benzin"},
                new Car{Id=4,BrandId=3,ColorId=1,ModelYear="2015",DailyPrice=250,Description="Manuel-LPG"},
                new Car{Id=5,BrandId=4,ColorId=4,ModelYear="2020",DailyPrice=460,Description="Otomatik-Benzin"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<Car> GetById(int ıd)
        {
            return _cars.Where(c => c.Id == ıd).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description; 
        } */
    }
}
