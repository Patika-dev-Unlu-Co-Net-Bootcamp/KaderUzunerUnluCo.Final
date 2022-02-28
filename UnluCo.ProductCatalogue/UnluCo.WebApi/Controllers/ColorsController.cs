using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductUnluCo.Application.Dto;
using ProductUnluCo.Application.Interface;
using ProductUnluCo.Application.ValidationRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace UnluCo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var colors = await _colorService.GetAll();
                return Ok(colors);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ColorDto colorDto)
        {
            try
            {
                ColorValidator validator = new ColorValidator();
                validator.ValidateAndThrow(colorDto);
                await _colorService.Add(colorDto);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] ColorDto colorDto)
        {

            _colorService.Update(colorDto);
            return Ok();
        }


    }
}

