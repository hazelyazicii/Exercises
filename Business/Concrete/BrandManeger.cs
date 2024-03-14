

using RentACar.Business.Abstract;
using RentACar.Business.BusinessRules;
using RentACar.Business.Requests.Fuel;
using RentACar.Business.Responses.Fuel;
using DataAccess.Abstract;
using RentACar.Entities.Concrete;
using RentACar.Business.Abstract;

namespace RentACar.Business.Concrete;

public class BrandManager(IBrandDal brandDal, BrandBusinessRules brandBusinessRules) : IBrandService
{
    public AddBrandResponse Add(AddBrandRequest request)
    {
        throw new NotImplementedException();
    }

    public IList<Fuel> GetList()
    {
        throw new NotImplementedException();
    }
}
