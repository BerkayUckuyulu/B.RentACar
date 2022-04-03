using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> RentalDetails()
        {
            using (CarRentalProjectContext context = new CarRentalProjectContext())
            {
                var result = from r in context.Rentals
                             join car in context.Cars on r.CarId equals car.CarId
                             join b in context.Brands on car.BrandId equals b.BrandId

                             join cust in context.Customers on r.CustomerId equals cust.UserId
                             join u in context.Users on cust.UserId equals u.UserId
                             select new RentalDetailDto
                             {
                                 CarId = r.CarId,
                                 CarName = b.BrandName,
                                 CustomerName = u.FirstName + " " + u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();

            }
        }
    }
}
