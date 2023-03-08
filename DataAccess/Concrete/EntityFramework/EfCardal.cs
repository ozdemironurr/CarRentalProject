using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCardal : EfEntityRepositoryBase<Car, RentalCarContext>, ICarDal
    {
        public List<CarDetailDTO> GetCarDetailsByBrandId(int brandId)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             where ca.BrandId == brandId
                             select new CarDetailDTO
                             {
                                 BrandName = br.BrandName,
                                 ModelName = ca.ModelName,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 BrandId = br.Id,
                                 ColorId = co.Id,
                                 Id = ca.Id,
                                 ModelYear = ca.ModelYear,
                                 Description = ca.Description,
                                 MinFindeksScore = ca.MinFindeksScore,
                                 CarImages = context.CarImages.Where(ci => ci.CarId == ca.Id).ToList()

                             };
                return result.ToList();
            }
        }

        public List<CarDetailDTO> GetCarDetailsByColorId(int colorId)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             where ca.ColorId == colorId
                             select new CarDetailDTO
                             {
                                 BrandName = br.BrandName,
                                 ModelName = ca.ModelName,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 BrandId = br.Id,
                                 ColorId = co.Id,
                                 Id = ca.Id,
                                 ModelYear = ca.ModelYear,
                                 Description = ca.Description,
                                 MinFindeksScore = ca.MinFindeksScore,
                                 CarImages = context.CarImages.Where(ci => ci.CarId == ca.Id).ToList()
                             };
                return result.ToList();
            }
        }

        public CarDetailDTO GetCarDetailsById(int id)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             where ca.Id == id
                             select new CarDetailDTO
                             {
                                 BrandName = br.BrandName,
                                 ModelName = ca.ModelName,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 BrandId = br.Id,
                                 ColorId = co.Id,
                                 Id = ca.Id,
                                 ModelYear = ca.ModelYear,
                                 Description = ca.Description,
                                 MinFindeksScore = ca.MinFindeksScore,
                                 CarImages = context.CarImages.Where(ci => ci.CarId == ca.Id).ToList()
                             };
                return result.First();
            }
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             select new CarDetailDTO
                             {
                                 BrandName = br.BrandName,
                                 ModelName = ca.ModelName,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 BrandId = br.Id,
                                 ColorId = co.Id,
                                 Id = ca.Id,
                                 ModelYear = ca.ModelYear,
                                 Description = ca.Description,
                                 MinFindeksScore = ca.MinFindeksScore,
                                 CarImages = context.CarImages.Where(ci => ci.CarId == ca.Id).ToList()

                             };
                return result.ToList();

            }
        }
    }
}
