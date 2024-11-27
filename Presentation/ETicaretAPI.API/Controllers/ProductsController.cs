using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        //[HttpGet]
        //public async Task Get()
        //{
        //    await _productWriteRepository.AddRangeAsync(
        //    new()
        //        {
        //            new()
        //            {
        //                Name = "C Product",
        //                Price = 1.500F,
        //                Stock = 10,
        //                CreatedAt = DateTime.UtcNow
        //            }
        //        }
        //    );

        //    await _productWriteRepository.SaveAsync();
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(string id)
        //{
        //    Product product = await _productReadRepository.GetByIdAsync(id);
        //    return Ok(product);
        //}
    }

}
