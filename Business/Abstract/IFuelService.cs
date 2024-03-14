

using RentACar.Business.Concrete;
using RentACar.Business.Requests.Fuel;
using RentACar.Business.Responses.Fuel;
using RentACar.Entities.Concrete;

namespace RentACar.Business.Abstract;

public interface IFuelService
{
    public AddFuelResponse Add(AddFuelRequest request);
    public IList<Fuel> GetList();
}