

using RentACar.Business.Abstract;
using RentACar.Business.BusinessRules;
using RentACar.Business.Requests.Fuel;
using RentACar.Business.Responses.Fuel;
using DataAccess.Abstract;
using RentACar.Entities.Concrete;

namespace RentACar.Business.Concrete;

public class FuelManager : IFuelService
{
    private readonly IFuelDal _FuelDal;
    private readonly FuelBusinessRules _FuelBusinessRules;
 

    public FuelManager(IFuelDal FuelDal, FuelBusinessRules FuelBusinessRules)
    {
        _FuelDal = FuelDal;
        _FuelBusinessRules = FuelBusinessRules;
       
    }

    public AddFuelResponse Add(AddFuelRequest request)
    {
        throw new NotImplementedException();
    }

    public IList<Fuel> GetList()
    {
        throw new NotImplementedException();
    }
}