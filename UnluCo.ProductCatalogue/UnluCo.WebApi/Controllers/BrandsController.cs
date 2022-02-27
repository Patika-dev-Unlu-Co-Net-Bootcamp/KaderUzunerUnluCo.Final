using Microsoft.AspNetCore.Mvc;
using ProductUnluCo.Application.Dto;
using ProductUnluCo.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace UnluCo.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;

        }
        [HttpGet]
        public async Task< IActionResult >Get()
        {
            try
            {
                
                var brands = await _brandService.GetAll();
                return Ok(brands);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetDetails(int id)
        {
            var brand = _brandService.GetById(id);
            return brand == null ? NoContent() : Ok(brand);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            BrandDto brandDelete = new BrandDto() { Id = id };
            _brandService.Delete(id);
            return Ok();

        }

        [HttpPost]
        public IActionResult Add([FromBody] BrandDto brandDto)
        {
            _brandService.Add(brandDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] BrandDto brandDto)
        {

            _brandService.Update(id, brandDto);
            return Ok();
        }

     
    }

}