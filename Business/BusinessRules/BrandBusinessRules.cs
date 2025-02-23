﻿using DataAccess.Abstract;

namespace RentACar.Business.BusinessRules;

public class BrandBusinessRules
{
    private readonly IBrandDal _brandDal;

    public BrandBusinessRules(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public void CheckIfBrandNameNotExists(string brandName)
    {
        bool isExists = _brandDal.GetList().Any(b => b.Name == brandName);
        if (isExists)
        {
            throw new Exception("Fuel already exists.");
        }
    }
}