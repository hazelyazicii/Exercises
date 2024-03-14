﻿using DataAccess.Abstract;

namespace RentACar.Business.BusinessRules;

public class FuelBusinessRules
{
    private readonly IFuelDal _FuelDal;

    public FuelBusinessRules(IFuelDal FuelDal)
    {
        _FuelDal = FuelDal;
    }

    public void CheckIfFuelNameNotExists(string FuelName)
    {
        bool isExists = _FuelDal.GetList().Any(b => b.Name == FuelName);
        if (isExists)
        {
            throw new Exception("Fuel already exists.");
        }
    }
}