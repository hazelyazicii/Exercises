

using RentACar.Business.Requests.Fuel;
using RentACar.Business.Responses.Fuel;
using RentACar.Entities.Concrete;

namespace RentACar.Business.Abstract;

public interface IBrandService
{
    public AddBrandResponse Add(AddBrandRequest request);

    public IList<Fuel> GetList();
}