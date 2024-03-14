using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using RentACar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class FuelDal : InMemoryEntityRepositoryBase<Fuel>, IFuelDal
    {
        protected override long generateId()
        {
            throw new NotImplementedException();
        }
    }
}
