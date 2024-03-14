
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Business.Abstract;
using RentACar.Business.Requests.Fuel;
using RentACar.Business.Responses.Fuel;
using RentACar.Entities.Concrete;
namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsController : ControllerBase
{
    private readonly IBrandService _brandService; 
    public BrandsController(IBrandService brandService)
    {
        _brandService = brandService;
    }

    public ICollection<Fuel> GetList()
    {
        IList<Fuel> brandList = _brandService.GetList();
        return brandList;
    }
    public ActionResult<AddBrandResponse> Add(AddBrandRequest request)
    {
        AddBrandResponse response = _brandService.Add(request);

        //return response; 
        return CreatedAtAction(nameof(GetList), response); 
    }
}