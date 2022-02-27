
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductUnluCo.Application.Dto;
using ProductUnluCo.Application.Interface;
using ProductUnluCo.Application.ValidationRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace UnluCo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
               
                var categories = await _categoryService.GetAll();
                return Ok(categories);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CategoryDto categoryDto)
        {
            try
            {
                 CategoryValidator validator = new CategoryValidator();
                validator.ValidateAndThrow(categoryDto);

                 await _categoryService.Add(categoryDto);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] CategoryDto categoryDto)
        {
            _categoryService.Update(categoryDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            CategoryDto categoryDto = new CategoryDto() { Id = id };
            _categoryService.Delete(categoryDto);
            return Ok();
        }
    }
}
