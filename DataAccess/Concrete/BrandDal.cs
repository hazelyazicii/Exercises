using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using RentACar.Core.DataAccess;
using RentACar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BrandDal : InMemoryEntityRepositoryBase<Brand>, IBrandDal
    {
        protected override long generateId()
        {
            throw new NotImplementedException();
        }
    }
}
