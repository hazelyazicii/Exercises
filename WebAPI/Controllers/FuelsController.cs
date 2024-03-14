
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Business.Abstract;
using RentACar.Business.Requests.Fuel;
using RentACar.Business.Responses.Fuel;
using RentACar.Entities.Concrete;
namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FuelsController : ControllerBase
{
    private readonly IFuelService _FuelService; 

    public FuelsController(IFuelService FuelService)
    {
        _FuelService = FuelService;
    }

  

    
    public ICollection<Fuel> GetList()
    {
        IList<Fuel> FuelList = _FuelService.GetList();
        return FuelList; // JSON
    }

    
    public ActionResult<AddFuelResponse> Add(AddFuelRequest request)
    {
        AddFuelResponse response = _FuelService.Add(request);

       
        return CreatedAtAction(nameof(GetList), response);
    }
}